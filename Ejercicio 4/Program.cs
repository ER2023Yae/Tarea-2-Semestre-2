using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cuadrado CuadradoO = new Cuadrado("Cuadrado", "Verde", 5);
            CuadradoO.CalcularPerimetro();
            CuadradoO.CalcularArea();
            CuadradoO.Informasao();

            Triangulo Triang = new Triangulo("Triangulo", "Rojo", 3, 4, 3, 3, 3);
            Triang.CalcularArea();
            Triang.CalcularPerimetro();
            Triang.Informasao();

            Circulo Circ = new Circulo("Circulo insano", "Morado", 5);
            Circ.CalcularArea();
            Circ.CalcularPerimetro();
            Circ.Informasao();
            Console.WriteLine();

        }
    }
}
