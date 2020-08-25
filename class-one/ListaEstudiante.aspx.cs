using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class ListaEstudiante : System.Web.UI.Page
    {
        string listado = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["listaEstudiante"] != null)
            {
                listado = (string)ViewState["listaEstudiante"];
                lbl_detalle.Text = listado;
            }
        }
        protected void agregarEstudiante(object sender, EventArgs e)
        {
            string nombre = txb_nombre.Text;
            string apellido = txb_apellido.Text;
            string celular = txb_celular.Text;
            string nuevoEstudiante = @"<tr>
                                <td>"+nombre+ "</td>" +
                                "<td>" + apellido + "</td>" +
                                "<td>" + celular + "</td></tr>";
            ViewState["listaEstudiante"] = listado + nuevoEstudiante;
            lbl_detalle.Text = listado + nuevoEstudiante;
        }
    }
}