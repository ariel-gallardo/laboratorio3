using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormularioDB : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RV_Nacimiento.MaximumValue = DateTime.Now.ToString("dd/MM/yyyy");
    }

    protected void ValidarSeleccion(object sender, ServerValidateEventArgs e)
    {
        e.IsValid = DDL_Sexo.SelectedValue != "N";
    }

    protected void AceptarTerminos(Object sender, EventArgs e)
    {
        if (CB_Aceptar.Checked && Page.IsValid)
        {
            B_Siguiente.Visible = true;
            Lab_Robot.Visible = true;
            B_Robot.Visible = true;
        }
        else
        {
            B_Siguiente.Visible = false;
            Lab_Robot.Visible = false;
            B_Robot.Visible = false;
        }
    }

    protected void EnviarFormulario(Object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Usuario usuario = new Usuario(TB_Email.Text, TB_EmailV.Text, TB_Password.Text,
                new Persona(TB_Nombre.Text, TB_Apellido.Text, TB_Nacimiento.Text, DDL_Sexo.SelectedValue, TB_Telefono.Text,
                    new Ubicacion(DDL_Ubicacion.SelectedValue, DDL_Ubicacion.SelectedItem.Text)
                )
            );
            if(usuario != null)
            {
                Conexion existencia = new Conexion();  
                existencia.Consultar("SELECT nombre FROM usuarios WHERE nombre ='" + usuario.Nombre + "'");
                existencia.MySqlDataReader = existencia.MySqlCommand.ExecuteReader();
                if (!existencia.MySqlDataReader.Read())
                {
                    existencia.Consultar("SELECT telefono FROM personas WHERE telefono = '" +usuario.Persona.Telefono+ "'");
                    existencia.MySqlDataReader = existencia.MySqlCommand.ExecuteReader();
                    if (!existencia.MySqlDataReader.Read())
                    {
                        existencia.Consultar("INSERT INTO personas(nombre,apellido,telefono,ubicacion_codigo) VALUES('"+usuario.Persona.Nombre+"', '"+usuario.Persona.Apellido + "', '" +usuario.Persona.Telefono + "', '" +usuario.Persona.Ubicacion.Codigo+ "')");
                        existencia.Consultar("SELECT id FROM personas WHERE telefono = '"+usuario.Persona.Telefono+"'");
                        existencia.MySqlDataReader = existencia.MySqlCommand.ExecuteReader();
                        String tempIDPersona = null;
                        if (existencia.MySqlDataReader.Read())
                        {
                            tempIDPersona = existencia.MySqlDataReader.GetString("id");
                        }
                        existencia.Consultar("INSERT INTO usuarios(nombre,alternativo,password,persona_id) VALUES('"+usuario.Nombre+ "', '"+usuario.Alternativo+ "', '" + usuario.Password+ "', '" + tempIDPersona + "')");
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Registrado exitosamente.')", true);
                        //Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ese numero esta registrado.')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se puede crear la cuenta.')", true);
                }
            }
        }
    }

}