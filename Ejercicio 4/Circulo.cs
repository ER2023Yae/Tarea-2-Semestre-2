using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Circulo : figura1
    {
        int radio;
        double resultado;

        public Circulo(string nombre, string color, int pradio) : base(nombre, color)
        {
            radio = pradio;
        }
        public override void CalcularArea()
        {
            resultado = 3.1416 * (radio * radio);
            Console.WriteLine("El Area es de " + resultado);
            Console.ReadKey();
        }
        public override void CalcularPerimetro()
        {
            resultado = 2 * 3.1416 * radio;
            Console.WriteLine("Su perimetro es de " + resultado);
            Console.ReadKey();
        }

        public override void Informasao()
        {
            base.Informasao();
        }
    }
}
