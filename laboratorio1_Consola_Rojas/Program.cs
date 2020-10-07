using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1_Consola_Rojas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "brian";
            string apellido = "Rojas Bedregal";
            int edad = 20;
            double talla = 1.20;
            bool sexo = true;

            Console.WriteLine($"nombre\n{nombre}");
            Console.WriteLine($"apellido\n{apellido}");
            Console.WriteLine($"edad\n{edad}");
            Console.WriteLine($"talla\n{talla}");
            // Console.WriteLine($"sexo{sexo}");
            if (sexo == true)
            {
                Console.WriteLine("sexo:" + "M");

            }
            else
            {
                Console.WriteLine("sexo:" + "f");
            }

            Console.ReadKey();
        }
    }
}
