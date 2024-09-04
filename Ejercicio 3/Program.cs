using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de términos que desea mostrar de la serie de Fibonacci");

            int numTerminos = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("La serie de Fibonacci es:");

            for (int i = 0; i < numTerminos; i++)

            {

                Console.Write(Fibonacci(i) + " ");

            }


            Console.ReadKey();
        }
        static int Fibonacci(int n)

        {

            if (n == 0 || n == 1)

            {

                return n;

            }

            else

            {

                return Fibonacci(n - 1) + Fibonacci(n - 2);

            }

        }
    }
}
