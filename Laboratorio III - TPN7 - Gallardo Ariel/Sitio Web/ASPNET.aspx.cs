using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ASPNET :  System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void MostrarDatosHTML(object sender, EventArgs e)
    {
        salCaja.InnerText = inpCaja.Text;
        salCombo.InnerText = comboSelect.Text;
        if (fImagen.PostedFile != null)
        {
            String ubicacion = Server.MapPath("~/upload/") + fImagen.PostedFile.FileName;
            fImagen.PostedFile.SaveAs(ubicacion);
            salImg.Src = "/upload/" + fImagen.PostedFile.FileName;
        }   
        salCheck.InnerText = Request.Form["chkBox"];
        salURL.HRef = inpURL.Text;
        salURL.InnerText = inpURL.Text;
        salRadio.InnerText = Request.Form["rTipo"];
        salOculto.InnerText = inpOculto.Text;
    }

}