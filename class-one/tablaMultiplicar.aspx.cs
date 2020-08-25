using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class tablaMultiplicar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void multiplicar(object sender, EventArgs e)
        {
            lbl_detalle.Text = "";
            int numero, i;
            int resultado;
            string linea =  txb_numero.Text;
            numero = int.Parse(linea);
            for (i = 1; i <= 12; i++)
            {
                resultado = numero * i;
                lbl_detalle.Text = lbl_detalle.Text + "<tr><td>" + numero + " * " + i + " = " + resultado + "</td></tr>";
            }

        }
    }
}