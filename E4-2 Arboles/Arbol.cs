using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2_Arboles
{
    class Arbol
    {
        int x = 0, y = 2;//Coordenadas 
        public void Agregar(Nodo nodo, string nombre, string[] nombres)//Metodo llamado relacionar nodos
        {
            if (nodo.Vinculo != null)//Si el atributo vinculo esta vacio por cada uno de los elementos se utiliza recursividad para agregar vinculo
            {
                foreach (Nodo item in nodo.Vinculo)
                {
                    Agregar(item, nombre, nombres);
                }
            }
            else// Si no esta vacio
            {
                if (nodo.Nombre == nombre)
                {
                    nodo.Vinculo = new Nodo[nombres.Length];//se crea arreglo de nodos al vinculo
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nodo.Vinculo[i] = new Nodo(nombres[i]);//asignandose valores
                    }
                }
            }
        }
        public void ArbolA()//Metodo que imprime el arbol
        {
            Console.WriteLine("Arbol A");
            Nodo Raiz = new Nodo("E");//Se declara a E como raiz
            Arbol Arbol = new Arbol();
            Arbol.Agregar(Raiz, "E", new string[] { "F", "A" });
            Arbol.Agregar(Raiz, "A", new string[] { "B", "C", "D" });
            Arbol.Imprimir(Raiz);
            Arbol.NivelAltura();
            Console.WriteLine("Ruta al elemento mas largo: E-->A-->(B,C,D)");

            Console.ReadKey();
        }

        public void ArbolB() //Igual con el metodo anterior pero con parametros distintos
        {
            Console.WriteLine("Arbol B");
            Nodo Raiz = new Nodo("C");
            Arbol Arbol = new Arbol();
            Arbol.Agregar(Raiz, "C", new string[] { "D", "F", "G", "A" });
            Arbol.Agregar(Raiz, "A", new string[] { "B" });
            Arbol.Agregar(Raiz, "B", new string[] { "E" });
            Arbol.Imprimir(Raiz);
            Arbol.NivelAltura();
            Console.WriteLine("Ruta al elemento mas largo: C-->A-->B-->E");

            Console.ReadKey();
        }

        public void ArbolC() //Igual que los dos metodos anteriores
        {
            Console.WriteLine("Arbol C");
            Nodo Raiz = new Nodo("K");
            Arbol Arbolito = new Arbol();
            Arbolito.Agregar(Raiz, "K", new string[] { "A", "C", "B", "D" });
            Arbolito.Agregar(Raiz, "D", new string[] { "I    J", "E" });
            Arbolito.Agregar(Raiz, "E", new string[] { "F", "G" });
            Arbolito.Agregar(Raiz, "G", new string[] { "H" });
            Arbolito.Imprimir(Raiz);
            Arbolito.NivelAltura();
            Console.WriteLine("Ruta al elemento mas largo: K-->D-->E-->G-->H");

            Console.ReadKey();
        }

        int Altura = 0, Nivel = 0;

        public void Imprimir(Nodo nodo)
        {

            if (nodo.Vinculo != null)// si el atributo se encuentra vacio
            {
                Console.SetCursorPosition(x, y);//Indica posicion en la que se colocara el cursor en consola 
                Console.Write(nodo.Nombre);
                x += 5;
                y++;
                for (int i = 0; i < nodo.Vinculo.Length; i++)
                {
                    Imprimir(nodo.Vinculo[i]);//recursividad
                }
                x += 5;
            }
            else// si no esta vacio
            {
                Console.SetCursorPosition(x, y);//Indica posicion en la que se colocara el cursor en consola
                Console.Write(nodo.Nombre);//se imprime el nombe
                y++;//se incrementa y
            }

            Altura = ((y - 1) / 2) - 1;
            Nivel = Altura;// nivel cambia al nuevo valor altura
        }

        public void NivelAltura()//Imprime datos de nivel y altura
        {
            Console.WriteLine("Altura: {0}", Altura);
            Console.WriteLine("Nivel: {0}", Nivel);

        }
    }
  }
