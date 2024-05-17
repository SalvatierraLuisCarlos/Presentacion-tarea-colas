using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESAR LA CANTIDAD DE COLAS QUE DESEA INGRESAR: ");
            int nosI = int.Parse(Console.ReadLine());

            Cola cola = new Cola();

            for (int i = 0; i < nosI; i++)
            {
                cola.InsertarNodo();
            }

            Console.WriteLine("COLA HA SIDO INGRESADA");
            cola.DesplegarCola();
            Console.ReadKey();
        }
    }
}

