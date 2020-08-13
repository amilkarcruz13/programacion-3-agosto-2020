using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class PromNotasDinamico : System.Web.UI.Page
    {
        List<string> materia = new List<string>(); 
        List<double> notaExamen = new List<double>();
        List<double> primerTarea = new List<double>();
        List<double> segundaTarea = new List<double>();
        List<double> tercerTarea = new List<double>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_promedio_Click(object sender, EventArgs e)
        {
            List<string> materia = new List<string>();
            List<double> notaExamen = new List<double>();
            List<double> primerTarea = new List<double>();
            List<double> segundaTarea = new List<double>();
            List<double> tercerTarea = new List<double>();
            string nombreMateria = txb_materia.Text;
            double v_notaExamen = Convert.ToDouble(txb_examen_mat.Text);
            double v_primerTarea = Convert.ToDouble(txb_primer_t_mat.Text);
            double v_segundaTarea = Convert.ToDouble(txb_segunda_t_mat.Text);
            double v_tercerTarea = Convert.ToDouble(txb_tercer_t_mat.Text);
            string detalle="";
            materia.Add(nombreMateria);
            notaExamen.Add(v_notaExamen);
            primerTarea.Add(v_primerTarea);
            segundaTarea.Add(v_segundaTarea);
            tercerTarea.Add(v_tercerTarea);
            for( int i = 0; i < materia.Count(); i++)
            {
                double notaExa = notaExamen[i] * 0.9;
                double promTarea = obtenerPromedioTareas(primerTarea[i], segundaTarea[i], tercerTarea[i]);
                double notaExaRound = Math.Round(notaExa, 2);
                double promTareaRound = Math.Round(promTarea, 2);
                detalle = detalle + @"<tr>
                                <td>"+ materia[i] +"</td>"+
                                "<td>"+ notaExa+"</td>"+
                                "<td>"+ promTarea+"</td> "+
                                "<td>"+ (notaExa + promTarea) + "</td></tr>" +
                                "<tr>" +
                                "<td> "+ materia[i] +"</td>"+
                                "<td>" + notaExaRound + "</td>" +
                                "<td>" + promTareaRound + "</td> " +
                                "<td>" + Math.Round((notaExa + promTarea), 2) + "</td></tr>" +
                                "<tr>" +
                                "<td> " + materia[i] + "</td>" +
                                "<td>" + Math.Floor(notaExa) + "</td>" +
                                "<td>" + Math.Floor(promTarea) + "</td> " +
                                "<td>" + Math.Floor((notaExa + promTarea)) + "</td></tr>" +
                                "<tr>" +
                                "<td>" + materia[i] + "</td>" +
                                "<td>" + Math.Ceiling(notaExa) + "</td>" +
                                "<td>" + Math.Ceiling(promTarea) + "</td> " +
                                "<td>" + Math.Ceiling((notaExa + promTarea)) + "</td></tr>" +
                            "";
            }
            lbl_detalle.Text = detalle;
        }
        double obtenerPromedioTareas(double pt, double st, double tt)
        {
            return ((pt + st + tt) / 3) * 0.1;
        }

        protected void btn_promedioD_Click(object sender, EventArgs e)
        {
            
            string nombreMateria = txb_materia.Text;
            double v_notaExamen = Convert.ToDouble(txb_examen_mat.Text);
            double v_primerTarea = Convert.ToDouble(txb_primer_t_mat.Text);
            double v_segundaTarea = Convert.ToDouble(txb_segunda_t_mat.Text);
            double v_tercerTarea = Convert.ToDouble(txb_tercer_t_mat.Text);
            string detalle = "";
            
            materia.Add(nombreMateria);
            notaExamen.Add(v_notaExamen);
            primerTarea.Add(v_primerTarea);
            segundaTarea.Add(v_segundaTarea);
            tercerTarea.Add(v_tercerTarea);
            for (int i = 0; i < materia.Count(); i++)
            {
                double notaExa = notaExamen[i] * 0.9;
                double promTarea = obtenerPromedioTareas(primerTarea[i], segundaTarea[i], tercerTarea[i]);
                double notaExaRound = Math.Round(notaExa, 2);
                double promTareaRound = Math.Round(promTarea, 2);
                detalle = detalle + @"<tr>" +
                                "<td> " + materia[i] + "</td>" +
                                "<td>" + notaExaRound + "</td>" +
                                "<td>" + promTareaRound + "</td> " +
                                "<td>" + Math.Round((notaExa + promTarea), 2) + "</td></tr>" +
                            "";
            }
            lbl_detalle.Text = lbl_detalle.Text + detalle;
        }
    }
}