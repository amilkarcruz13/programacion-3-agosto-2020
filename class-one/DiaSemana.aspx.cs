using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class DiaSemana : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string mensaje()
        {
            string texto = "Soy el mensaje";
            return texto;
        }
        protected void btn_semana_Click(object sender, EventArgs e)
        {
            int numeroDia = Convert.ToInt16(txb_numero.Text);
            switch (numeroDia)
            {
                case 1:
                    lbl_resultado.Text = " El día 1 de la semana es el día Lunes";
                    break;
                case 2:
                    lbl_resultado.Text = " El día 2 de la semana es el día Martes";
                    break;
                case 3:
                    lbl_resultado.Text = " El día 3 de la semana es el día Miercoles";
                    break;
                case 4:
                    lbl_resultado.Text = " El día "+ numeroDia +" de la semana es el día Jueves";
                    break;
                case 5:
                    lbl_resultado.Text = " El día " + numeroDia + " de la semana es el día Viernes";
                    break;
                case 6:
                    lbl_resultado.Text = " El día " + numeroDia + " de la semana es el día Sabado";
                    break;
                case 7:
                    lbl_resultado.Text = " El día " + numeroDia + " de la semana es el día Domingo";
                    break;
                default:
                    lbl_resultado.Text = "Los días de la semana son 7..!!";
                    break;

            }
        }
    }
}