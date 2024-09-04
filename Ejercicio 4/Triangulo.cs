using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Triangulo : figura1
    {
        public int basee;
        public int Altura;
        public int Resultado;
        public int Lado1;
        public int Lado2;
        public int Lado3;

        public Triangulo(string nombre, string color, int baseee, int altura, int lado1, int lado2, int lado3) : base(nombre, color)
        {
            basee = baseee;
            Altura = altura;
         
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override void CalcularArea()
        {

            Resultado = (basee * Altura) / 2;
            Console.WriteLine(" El area del triangulo es de " + Resultado);
            Console.ReadKey();

        }

        public override void CalcularPerimetro()
        {
            Resultado = Lado1 + Lado2 + Lado3;
            Console.WriteLine("El perimetro del triangulo es de " + Resultado);
            Console.ReadKey();
        }

        public override void Informasao()
        {
            base.Informasao();
        }
    }
}
