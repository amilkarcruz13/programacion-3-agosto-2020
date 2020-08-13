using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class Condicionales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_verificar_Click(object sender, EventArgs e)
        {
            /* int sueldo = Convert.ToInt16(txb_dato.Text);
            if(sueldo > 3000)
            {
                lbl_resultado.Text = "Su sueldo es "+ sueldo +", tiene que pagar impuestos";
                lbl_resultado.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl_resultado.Text = "Su sueldo es menor a 3000, no paga impuestos";
                lbl_resultado.BackColor = System.Drawing.Color.SkyBlue;
            } */
            int parametro = Convert.ToInt16(txb_dato.Text);
            int[] sueldos = { 7500, 3500, 5000, 2100, 10000, 3500, 7000, 700, 7000 };
            string resultado = @"<table class='table table-bordered'>
                                    <tr style='background: #5cb85c; color:#fff'>
                                        <th>Funcionario</th>
                                        <th>Sueldo</th>
                                        <th>Impuesto</th>
                                    </tr>";
            for (int i = 0; i < sueldos.Length; i++)
            {
                if(sueldos[i] > parametro)
                {
                    resultado = resultado + "<tr style='background:#5bc0de; color:#fff'><td>Funcionario " + (i + 1) +"</td><td>" + sueldos[i] + "</td><td>Pagará Impuesto</td></tr>";
                }
                else
                {
                    resultado = resultado + "<tr><td>Funcionario " + (i + 1) + "</td><td>" + sueldos[i] + "</td><td>No Pagará Impuesto</td></tr>";
                }

            }
            resultado = resultado + "</table>";
            tbl_impuestos.Text = resultado;

        }
    }
}