using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["totalVenta"] != null)
            {
                lbl_total.Text = "El total de ventas es:" + ((int)Session["totalVenta"]).ToString();
            }
            if (Session["cantidadProducto"] != null)
            {
                lbl_inventario.Text = (int)Session["cantidadProducto"] + " Productos en inventario";
            }
            if (Session["listaCliente"] != null)
            {
                lbl_detalle.Text = (string)Session["listaCliente"];
            }
        }
    }
}