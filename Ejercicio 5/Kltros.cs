using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Kltros : Unidades
    {


        public override void calcular()
        {
            Console.WriteLine("Cantidad de su unidad");
            double cant = Convert.ToDouble(Console.ReadLine());
            double KMm = cant * 1000;
            double KMcm = cant / 100000;

            Console.WriteLine("Km a M= " + KMm);
            Console.WriteLine("Km a Cm= " + KMcm);
            Console.ReadKey();
        }
    }
}
