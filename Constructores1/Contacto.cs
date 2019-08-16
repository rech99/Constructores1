using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores1
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }



        public Contacto()
        {
            Nombre = "Sin Nombre";
            Celular = "Sin Celular";
            Telefono = "Sin Telefono";
            Correo = "Sin Correo";
            Direccion = "Sin Direccion";
        }

        public Contacto(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin Celular";
            Telefono = "Sin Celular";
            Direccion = "Sin Direccion";

        }


        public Contacto(string nombre, string celular, 
            string telefono, string correo, string direccion)
        {

        }
            
          
    }
}
