using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class conversionDolar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cambio_Click(object sender, EventArgs e)
        {
            double cantidad, tipoCambio, resultado;
            string cambio = txb_cambio.Text;
            bool verificarTC = Double.TryParse(cambio, out double numero);
            if (verificarTC == true)
            {
                cambio = cambio.Replace(".", ",");
                cantidad = Convert.ToDouble(txb_cantidad.Text);
                tipoCambio = Convert.ToDouble(cambio);
                resultado = convertir(tipoCambio, cantidad);
                lbl_resultado.Text = "El equivalente en $ es: " + resultado;
            }
            else
            {
                lbl_resultado.Text = "El tipo de cambio debe ser un valor decimal";
            }

        }
        double convertir(double cambio,double cantidad)
        {
            double resultado = cantidad / cambio;
            resultado = Math.Round(resultado, 2);
            return resultado;
        }
    }
}