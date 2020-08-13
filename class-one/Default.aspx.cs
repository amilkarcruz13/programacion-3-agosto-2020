using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Mensaje de bienvenido
            string mensaje = "Hola mundo";
            
        }

        protected void btn_sumar_Click(object sender, EventArgs e)
        {
            int dato1 = Convert.ToInt16(txb1.Text);
            int dato2 = Convert.ToInt16(txb2.Text);
            int resultado = dato1 + dato2;
            lbl_suma.Text = Convert.ToString(resultado);

        }
    }
}