using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasAuto
{
    public class Cola
    {
        private Nodos Primero;
        private Nodos Ultimo;

        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNodo()
        {
            Nodos nuevoNodo = new Nodos();
            Console.Write("INSERTE UN NUEVO DATO QUE TENDRA EL NODO: ");
            nuevoNodo.Dato = int.Parse(Console.ReadLine());
            nuevoNodo.Siguiente = null;

            if (Primero == null)
            {
                Primero = nuevoNodo;
                Ultimo = nuevoNodo;
            }
            else
            {
                Ultimo.Siguiente = nuevoNodo;
                Ultimo = nuevoNodo;
            }

            Console.WriteLine("NODO INSERTADO");
        }

        public void DesplegarCola()
        {
            Nodos actual = Primero;

            if (actual != null)
            {
                while (actual != null)
                {
                    Console.WriteLine("" + actual.Dato);
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("NO HAY NODOS EN LA COLA");
            }
        }
    }

}
