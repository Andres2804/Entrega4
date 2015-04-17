using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMayorEdad
{
    class Persona
    {
        //Atributos
        String nombre;
        int edad;

        //Contructor vacio
        public Persona()
        {

        }

        //Metodo Constructor
        public Persona(String nombre2, int edad2)
        {
            this.nombre = nombre2;
            this.edad = edad2;
        }

        //Metodos Get y Set
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
