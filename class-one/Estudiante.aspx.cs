using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace class_one
{
    public partial class Estudiante : System.Web.UI.Page
    {
        Persona Jose = new Persona("Jose","Mercado", "1995-05-01");
        Persona Mario = new Persona("Mario","Mercado","1994-05-02");
        protected void Page_Load(object sender, EventArgs e)
        {
            Mario.Nombre = "Juan Mario";
            lbl_mensaje.Text = Mario.saludar();
            lbl_mensaje2.Text = Jose.saludar();
        }
    }
}