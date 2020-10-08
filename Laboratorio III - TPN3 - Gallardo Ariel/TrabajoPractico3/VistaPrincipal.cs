using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico3.Controlador;
using TrabajoPractico3.Modelo;

namespace TrabajoPractico3
{
    public partial class VistaPrincipal : Form
    {
        public ControladorPais ControladorPais { get; set; }
        public ControladorCiudad ControladorCiudad { get; set; }
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            ControladorPais = new ControladorPais();
            ControladorPais.CargarPaises(DGVPais);
            ControladorCiudad = new ControladorCiudad(ControladorPais);
            ControladorCiudad.CargarCiudades(DGVCiudad);
        }

        private void cB_b_Poblacion_CheckedChanged(object sender, EventArgs e)
        {
            TB_B_Poblacion.Enabled = TB_B_Poblacion.Enabled ? false : true;
            if (!TB_B_Poblacion.Enabled)
            {
                TB_B_Poblacion.Text = "";
            }
        }

        private void cB_b_Pais_CheckedChanged(object sender, EventArgs e)
        {
            TB_B_Pais.Enabled = TB_B_Pais.Enabled ? false : true;
            if (!TB_B_Pais.Enabled)
            {
                TB_B_Pais.Text = "";
            }
        }

        private void cB_b_Ciudad_CheckedChanged(object sender, EventArgs e)
        {
            TB_B_Ciudad.Enabled = TB_B_Ciudad.Enabled ? false : true;
            if (!TB_B_Ciudad.Enabled)
            {
                TB_B_Ciudad.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(TB_B_Ciudad.Enabled || TB_B_Pais.Enabled || TB_B_Poblacion.Enabled)
            {
                ControladorCiudad.BuscarCiudad(
                        TB_B_Ciudad.Text, TB_B_Poblacion.Text, TB_B_Pais.Text,
                        DGVCiudad, DGVPais
                    );
            }
            else
            {
                ControladorCiudad.Restaurar(DGVCiudad);
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(String.Empty != TB_C_Ciudad.Text && TB_C_Poblacion.Text != String.Empty && DGVPais.CurrentRow.Selected)
            {
                ControladorCiudad.CrearCiudad(
                        TB_C_Ciudad.Text, TB_C_Poblacion.Text, 
                        DGVPais.CurrentRow.Cells[1].Value.ToString()
                    );
            }
            else
            {
                MessageBox.Show("Debe completar los campos");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ControladorCiudad.Actualizar(
                    DGVCiudad.CurrentRow.Index,
                    TB_C_Ciudad.Text, TB_C_Poblacion.Text,
                    DGVPais.CurrentRow.Cells[1].Value.ToString(),
                    ControladorPais, DGVCiudad
                );
        }

        private void DGVCiudad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ControladorCiudad.SelCiudad(TB_C_Ciudad, TB_C_Poblacion, DGVCiudad, DGVPais);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ControladorCiudad.Eliminar(DGVCiudad.CurrentRow.Index, DGVCiudad);
        }
    }
}
