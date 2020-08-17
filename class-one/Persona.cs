using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace class_one
{
    public class Persona
    {
        //ATRIBUTOS
        private string nombre;
        private string apellido;
        private string fechaNac;
        //PROPERTY
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        public Persona(string p_nombre, string p_apellido, string p_fecha_nac)
        {
            nombre = p_nombre;
            apellido = p_apellido;
            fechaNac = p_fecha_nac;
        }
        public string saludar()
        {
            return "Hola soy: "+nombre+" "+apellido;
        }
        public string obtenerEdad()
        {
            return "Aqui veras mi edad";
        }
    }
}