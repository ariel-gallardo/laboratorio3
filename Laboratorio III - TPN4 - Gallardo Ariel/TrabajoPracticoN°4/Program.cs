using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN_4
{
    class Program
    {
        static void Main(string[] args)
        {
            crearBackup50("articulo");
            restaurarBackup50("articulo", "articulo_copy");
        }

        public static void crearBackup50(String nomTabla)
        {
            long cantRegistros = new Conexion().ObtenerCantidadRegistro(nomTabla);
            List<String> Filas = new List<string>();
            Filas.Add(new Conexion().ObtenerNombreColumnas("articulo"));
            long limSup = 0, limInf = 0;
            StreamWriter streamWriter = null;

            while (limInf < cantRegistros)
            {
                limSup = (limInf % 50 == 0 ? 50 : cantRegistros % 50);
                Filas.AddRange(new Conexion().ObtenerFilas(nomTabla, limInf, limSup));
                
                try
                {
                    streamWriter = new StreamWriter(@"D:\temp"+nomTabla+".txt", true);
                    Filas.ForEach(delegate (String fila) {
                        streamWriter.WriteLine(fila);
                    }); 
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Se ha producido un error \n" + e.Message);
                }
                finally
                {
                    streamWriter.Close();
                    Filas.Clear();
                }

                limInf += 50;
            }
        }

        public static void restaurarBackup50(String tabla, String destino = "")
        {
            StreamReader streamReader = new StreamReader(@"D:\temp" + tabla + ".txt");

            String campos = streamReader.ReadLine(),
                valores = "";
            if(campos != null)
            {
                while(true)
                {
                    
                    valores = streamReader.ReadLine();
                    if(valores != null)
                    {
                        String[] tempLista = valores.Split('\t');
                        tempLista[1] = DateTime.Parse(tempLista[1]).ToString();
                        tempLista[4] = tempLista[4].Replace(",", ".");
                        valores = String.Join("\t", tempLista);
                        valores = valores.Replace("\t", "', '");
                        if(new Conexion().existeRegistro(tabla, long.Parse(tempLista[0])))
                        {
                            List<String> arrCampos = new List<string>(campos.Split('\t'));
                            String updCampos = "";
                            for (int i = 0; i < arrCampos.Count; i++)
                            {
                                if(updCampos != String.Empty)
                                {
                                    updCampos += (arrCampos[i] + " = '" + tempLista[i]);
                                    updCampos = ("', '" + updCampos);
                                }
                                else if(i == 0 || i == arrCampos.Count-1)
                                {
                                    updCampos += "'";
                                }
                            }   
                            new Conexion("UPDATE "+tabla+" SET "+updCampos);
                        }
                        else
                        {
                            campos = campos.Replace("\t", ", ");
                            new Conexion("INSERT INTO " + (destino != String.Empty ? destino : tabla) + " (" + campos + ") VALUES ('" + valores + "')");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

    }
}
