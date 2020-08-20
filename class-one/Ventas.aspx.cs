using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class Ventas : System.Web.UI.Page
    {
        int totalVentaGlobal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["totalVenta"] != null)
            {
                totalVentaGlobal = (int)Session["totalVenta"];
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            string producto = txb_producto.Text;
            int precio = Convert.ToInt32(txb_precio.Text);
            
            Session["totalVenta"] = precio + totalVentaGlobal; ;

            lbl_total.Text = ((int)Session["totalVenta"]).ToString();
            lbl_detalle.Text = lbl_detalle.Text + "<tr><td>"+producto+ "</td><td>" + precio + "</td></tr>";
        }
    }
}