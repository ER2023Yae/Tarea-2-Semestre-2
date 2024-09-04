using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su unidad de medida");
            Console.WriteLine("1. dd/mm/aa --> MM/AA/dddd");
            Console.WriteLine("2. MM/AA/dddd --> dd/mm/aa");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {

                case 1:
                    FechaBasica fechanormal = new FechaBasica();
                    fechanormal.CambiarFormatoFecha();
                    break;
                case 2:
                    Fechausa fechausa = new Fechausa();
                    fechausa.CambiarFormatoFecha();
                    break;

                default:
                    Console.WriteLine("ERROR, numero fuera de los parametros");
                    break;

            }
        }
    }
}
