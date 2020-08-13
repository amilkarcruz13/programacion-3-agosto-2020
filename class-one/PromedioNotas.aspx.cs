using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class PromedioNotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_promedio_Click(object sender, EventArgs e)
        {
            double nota_exa_mat = Convert.ToDouble(txb_examen_mat.Text); 
            double nota_exa_fis= Convert.ToDouble(txb_examen_fis.Text); 
            double nota_exa_qui= Convert.ToDouble(txb_examen_qui.Text);
            
            double primer_t_mat = Convert.ToDouble(txb_primer_t_mat.Text);
            double primer_t_fis= Convert.ToDouble(txb_primer_t_fis.Text);
            double primer_t_qui= Convert.ToDouble(txb_primer_t_qui.Text);

            double segunda_t_ma = Convert.ToDouble(txb_segunda_t_mat.Text);
            double segunda_t_fis = Convert.ToDouble(txb_segunda_t_fis.Text);
            double segunda_t_qui = Convert.ToDouble(txb_segunda_t_qui.Text);

            double tercer_t_mat = Convert.ToDouble(txb_tercer_t_mat.Text);
            double tercer_t_qui = Convert.ToDouble(txb_tercer_t_qui.Text);

            double promedio_t_mat = ((primer_t_mat + segunda_t_ma + tercer_t_mat) / 3 ) * 0.1;
            double examen_mat = nota_exa_mat * 0.9;
            double nota_final_mat = promedio_t_mat + examen_mat;

            double promedio_t_fis = ((primer_t_fis + segunda_t_fis) / 2) * 0.2;
            double examen_fis = nota_exa_fis * 0.8;
            double nota_final_fis = promedio_t_fis + examen_fis;

            double promedio_t_qui = ((primer_t_qui  + segunda_t_qui + tercer_t_qui) / 3) * 0.15;
            double examen_qui = nota_exa_qui * 0.85;
            double nota_final_qui = promedio_t_qui + examen_qui;

            double promedio_final = (nota_final_mat + nota_final_fis + nota_final_qui) / 3;

            lbl_detalle.Text = @"<tr>
                                    <td>"+ nota_final_mat+"</td>"+
                                    "<td>"+ nota_final_fis+"</td>"+
                                    "<td>"+ nota_final_qui+"</td>"+
                                    "<td>"+ promedio_final+"</td> "+
                                "</tr>";
        }
    }
}