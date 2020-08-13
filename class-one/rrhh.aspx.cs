using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class rrhh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_incremento_Click(object sender, EventArgs e)
        {
            double sueldoActual = Convert.ToDouble(txb_salario.Text);
            double sueldoNuevo;
            string nombreObrero = txb_nombre.Text;
            double incremento = sueldoActual * 0.25;
            sueldoNuevo = sueldoActual + incremento;
            //lbl_resultado.Text = "El nuevo sueldo de " + nombreObrero + " es: " + sueldoNuevo + " Bs.";
            lbl_detalle.Text = @"<tr>
                                    <td>"+ nombreObrero +"</td>"+
                                    "<td>"+ sueldoActual +" Bs.</td>" +
                                    "<td>"+ incremento +" Bs.</td>" +
                                    "<td>"+ sueldoNuevo +" Bs.</td>" +
                                "</tr>";
        }
    }
}