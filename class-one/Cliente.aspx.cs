using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class Cliente : System.Web.UI.Page
    {
        string listado = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["listaCliente"] != null)
            {
                listado = (string)Session["listaCliente"];
                lbl_detalle.Text = listado;
            }
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            string nombre = txb_nombre.Text;
            string apellido = txb_apellido.Text;
            string celular = txb_celular.Text;
            string detalle = @"<tr><td>" + nombre + "</td>" +
            "<td>" + apellido + "</td>" +
            "<td>" + celular + "</td></tr>";
            lbl_detalle.Text = listado + detalle;
            Session["listaCliente"] = listado + detalle;
        }
    }
}