using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su unidad de medida");
            Console.WriteLine("1. Cm");
            Console.WriteLine("2. M");
            Console.WriteLine("3. Km");
            int opc = Convert.ToInt32(Console.ReadLine());
           
            switch (opc)
            {

                case 1:
                    Cm Cm1 = new Cm();
                    Cm1.calcular();
                    break;

                case 2:
                    Met Met1 = new Met();
                    Met1.calcular();
                    break;
                case 3:
                    Kltros Km1 = new Kltros();
                    Km1.calcular();
                    break;
                default:
                    Console.WriteLine("ERROR, Ingrese un caracter valido");

                    break;
            }


            Console.ReadKey();
        }
    }
}
