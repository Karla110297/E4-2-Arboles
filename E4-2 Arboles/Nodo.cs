using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2_Arboles
{
    class Nodo
    {
        //atributos
        string nombre;
        public Nodo[] Vinculo;

        //propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

     

        //constructores
        public Nodo() { }



        public Nodo(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
