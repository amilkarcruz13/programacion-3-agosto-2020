using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class Inventario : System.Web.UI.Page
    {
        int cantidadAlmacen = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["cantidadProducto"] != null)
            {
                cantidadAlmacen = (int)Session["cantidadProducto"];
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            string producto = txb_producto.Text;
            int cantidad = Convert.ToInt16(txb_cantidad.Text);
            Session["cantidadProducto"] = cantidad + cantidadAlmacen;
            lbl_detalle.Text = lbl_detalle.Text + "<tr><td>"+producto+"</td><td>"+cantidad+"</td></tr>";
        }
    }
}