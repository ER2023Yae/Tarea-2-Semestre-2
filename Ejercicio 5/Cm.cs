using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Cm : Unidades
    {
        public override void calcular()
        {
            Console.WriteLine("Cantidad de su unidad");
            double cant = Convert.ToDouble(Console.ReadLine());
            double cmM = cant / 100;
            double cmKm = cant / 100000;

            Console.WriteLine("Cm a M= " + cmM);
            Console.WriteLine("Cm a Km= " + cmKm);
            Console.ReadKey();
        }


    }
}
