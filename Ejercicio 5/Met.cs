using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Met : Unidades
    {

        public override void calcular()
        {
            Console.WriteLine("Cantidad de su unidad");
            double cant = Convert.ToDouble(Console.ReadLine());
            double Mcm = cant * 100;
            double Mkm = cant / 1000 ;

            Console.WriteLine("M a Cm= " + Mcm );
            Console.WriteLine("M a Km= " + Mkm);
            Console.ReadKey();
        }
    }
}
