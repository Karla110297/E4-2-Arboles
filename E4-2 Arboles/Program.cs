using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2_Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol Arbol= new Arbol();//llamda a clase arbol
            //llamada a metodos
            Arbol.ArbolA();
            Console.Clear();
            Arbol.ArbolB();
            Console.Clear();
            Arbol.ArbolC();
        }
    }
}
