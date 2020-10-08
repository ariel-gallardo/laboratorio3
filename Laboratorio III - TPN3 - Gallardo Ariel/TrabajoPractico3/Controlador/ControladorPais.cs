using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3.Dato;
using TrabajoPractico3.Modelo;

namespace TrabajoPractico3.Controlador
{
    public class ControladorPais
    {
        public static Dictionary<String, Pais> Paises()
        {
            return Pais.Paises;
        }

        public ControladorPais()
        {
            
        }

        public void CargarPaises(System.Windows.Forms.DataGridView dataGridView)
        {
            Pais.cargarPaises();
            dataGridView.DataSource = paisesLista();
        }

        public List<Pais> paisesLista()
        {
            return Pais.Paises.Values.ToList();
        }
    }
}
