using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class FechaBasica
    {

        public virtual void CambiarFormatoFecha()
        {

            Console.WriteLine("Ingrese el dia");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el anio");
            int anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fecha normal " + dia + "/" + mes + "/" + anio);
            
            Console.ReadKey();
        }
    }
}
