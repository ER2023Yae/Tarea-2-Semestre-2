using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número para calcular su factorial");

            int numero = Convert.ToInt32(Console.ReadLine());


            int resultado = CalcularFactorial(numero);


            Console.WriteLine("El factorial del número: " + numero + " es: " + resultado);


            Console.ReadKey();
        }

        static int CalcularFactorial(int numero, int suma = 1)

        {

            if (numero == 0)

            {

                return suma;

            }

            else

            {

                Console.WriteLine("Variable suma: " + suma);

                Console.WriteLine("Variable numero: " + numero);

                Console.WriteLine(suma + " * " + numero + " = " + (suma * numero));

                return CalcularFactorial(numero - 1, suma * numero);

            }

        }
    }
}
