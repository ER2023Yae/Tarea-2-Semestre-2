using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número que desea saber su tabla de multiplicar");

            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque hasta donde desea llegar la multiplicación");

            double cant = Convert.ToDouble(Console.ReadLine());


            ImprimirTabla(num, 0, cant);


            Console.ReadKey();

        }


        static void ImprimirTabla(double num, double i, double cant)

        {

            if (i <= cant)

            {

                double resultado = num * i;

                Console.WriteLine(num + " X " + i + " = " + resultado);

                ImprimirTabla(num, i + 1, cant);

            }

        }
    }
    }

