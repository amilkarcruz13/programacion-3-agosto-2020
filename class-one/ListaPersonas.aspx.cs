using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class ListaPersonas : System.Web.UI.Page
    {
        List<Persona> personas = new List<Persona>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(ViewState["personas"] != null)
            {
                personas = (List<Persona>)ViewState["personas"];
            }
        }
        protected void guardar(object sender, EventArgs e)
        {
            string nombre = txb_nombre.Text;
            string apellido = txb_apellido.Text;
            string fechaNac = txb_fecha.Text;
            Persona persona = new Persona(nombre,apellido, fechaNac);
            personas.Add(persona);
            ViewState["personas"] = personas;

            lbl_mensaje.Text = detalle();
        }
        string detalle()
        {
            string resultado = "";
            for (int i =0; i < personas.Count(); i++)
            {
                resultado = resultado + "<tr><td>" + personas[i].Nombre + "</td>" +
                    "<td>" + personas[i].Apellido + "</td>" +
                    "<td>" + personas[i].FechaNac + "</td>" +
                    "</tr>";

            }
            return resultado;
        }
    }
}