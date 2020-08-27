using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class_one
{
    public partial class MayorMenor_Lista : System.Web.UI.Page
    {
        string ejemplo = "algo";
        List<int> numeros = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["listado"] != null)
            {
                numeros = (List<int>)ViewState["listado"];
            }
        }
        protected void mayorMenor(object sender, EventArgs e)
        {
            lbl_detalle.Text = resultado("UPC");
        }
        protected void agregar(object sender, EventArgs e)
        {
            int limite = Convert.ToInt16(txb_limite.Text);
            int numero = Convert.ToInt16(txb_numero.Text);
            //lista inicia la cantidad de sus elementos a partir de 0
            //ejemplo { 15 , 20 , 50}
            //ejemplo { persona{'amilkar', 'cruz', '08/05/1991'}, persona{'jorge', 'mercado', '01/01/1980'} }
            //          0     1    2
            //lista.tamaño = 2
            //lista.contar = 3
            if (numeros.Count < limite)
            {
                numeros.Add(numero);
            }
            ViewState["listado"] = numeros;
            lbl_detalle.Text = detalle(); 
        }
        string resultado(string dinamico)
        {
            string elementos = "";
            int mayor = numeros.Max();
            int menor = numeros.Min();
            for (int i = 0; i < numeros.Count(); i++)
            {
                elementos = elementos + numeros[i] + ",";
            }
            string fila = "<tr>"+
                        "<td>" + elementos + "</td>" +
                        "<td>" + mayor + "</td>" +
                        "<td>" + menor + "</td>" +
                        "<td>" + (mayor - menor) + "</td></tr>" +
                        "<tr><td colspan='3'>"+dinamico+"</td></tr>";
            return fila;
        }
        string resultado()
        {
            string elementos = "";
            int mayor = 0;
            int menor = 0;
            for (int i =0; i < numeros.Count(); i++)
            {
                elementos = elementos + numeros[i] + ",";
                if(i == 0)
                {
                    mayor = numeros[i];
                    menor = mayor;
                }
                if (numeros[i] > mayor) mayor = numeros[i];
                if (numeros[i] < menor) menor = numeros[i];
            }
            string fila = @"
                        <tr><td>" + elementos + "</td>" +
                        "<td>"+mayor+"</td>" +
                        "<td>" + menor + "</td>" +
                        "<td>" + (mayor - menor) + "</td>" +
                        "</tr>";
            return fila;
        }
        string detalle()
        {
            string elementos = "";
            for (int i = 0; i < numeros.Count(); i++)
            {
                elementos = elementos + numeros[i] + " , ";
            }
            string fila = @"
                        <tr><td>"+elementos+ "</td>" +
                        "<td>Mayor</td>" +
                        "<td>Menor</td> " +
                        "<td>Diferencia</td></tr>";
            return fila;
        }
    }
}