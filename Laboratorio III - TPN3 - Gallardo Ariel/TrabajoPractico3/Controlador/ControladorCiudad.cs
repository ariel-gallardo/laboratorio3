using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3.Dato;
using TrabajoPractico3.Modelo;

namespace TrabajoPractico3.Controlador
{
    public class ControladorCiudad
    {
        
        public ControladorPais ControladorPais { get; set; }
        public ControladorCiudad(ControladorPais _ControladorPais)
        {
            ControladorPais = _ControladorPais;
        }

        public void CrearCiudad(String _Nombre, String _Poblacion, String _Pais)
        {
            new Ciudad(_Nombre, long.Parse(_Poblacion), ControladorPais.Paises()[_Pais]).CrearCiudad();
        }

        public void CargarCiudades(System.Windows.Forms.DataGridView dataGridView)
        {
            Ciudad.cargarCiudades();
            dataGridView.DataSource = Ciudad.Ciudades;
        }

        public void BuscarCiudad(String _Ciudad, String Poblacion, String Pais, System.Windows.Forms.DataGridView DGVCiudad, System.Windows.Forms.DataGridView DGVPais)
        {
            DGVCiudad.DataSource = null;
            Ciudad.Ciudades.Clear();
            Ciudad.BuscarCiudad(_Ciudad, Poblacion, Pais);
            DGVCiudad.DataSource = Ciudad.Ciudades;
            if(Ciudad.Ciudades.Count > 0)
            {
                DGVCiudad.CurrentRow.Selected = false;
            }
            DGVPais.CurrentRow.Selected = false;
            DGVCiudad.Refresh();
        }

        public void Restaurar(System.Windows.Forms.DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            Ciudad.Ciudades.Clear();
            CargarCiudades(dataGridView);
        }

        public void Actualizar(int Seleccion, String Nombre, String Poblacion, String _Pais, ControladorPais controladorPais, System.Windows.Forms.DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            Ciudad.ModificarCiudad(Nombre, Poblacion, _Pais, Seleccion);
            CargarCiudades(dataGridView);
        }

        public void SelCiudad(System.Windows.Forms.TextBox TB_C_Ciudad, System.Windows.Forms.TextBox TB_C_Poblacion, System.Windows.Forms.DataGridView DGVCiudad, System.Windows.Forms.DataGridView DGVPais)
        {
            TB_C_Ciudad.Text = DGVCiudad.CurrentRow.Cells[0].Value.ToString();
            TB_C_Poblacion.Text = DGVCiudad.CurrentRow.Cells[1].Value.ToString();
            int index = 0;

            if(CiudadesLista()[DGVCiudad.CurrentRow.Index].Pais != null)
            {
                index = ControladorPais.paisesLista().IndexOf(CiudadesLista()[DGVCiudad.CurrentRow.Index].Pais);
            }
            else
            {
                index = DGVPais.CurrentRow.Index;
            }
            
            DGVPais.Rows[index].Selected = true;
            DGVPais.FirstDisplayedScrollingRowIndex = index;
        }

        public List<Ciudad> CiudadesLista()
        {
            return Ciudad.Ciudades;
        }

        public void Eliminar(int i, System.Windows.Forms.DataGridView DGVCiudad)
        {
            Ciudad.Ciudades[i].EliminarCiudad();
            Restaurar(DGVCiudad);
        }
    }
}
