using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Cuadrado : figura1
    {
        int Lado;
        int Resultado;

        public Cuadrado(string nombre, string color, int lado) : base(nombre,color)
        {
            Lado = lado;
            
        }

        public override void CalcularArea()
        {
            Resultado = Lado * Lado;
            Console.WriteLine(" El area del Cuadrado es " + Resultado);
            Console.ReadKey();
        }
        public override void CalcularPerimetro() 
        {


            Resultado = 4 * Lado;
            Console.WriteLine(" El perimetro del cuadrado es " + Resultado);
            Console.ReadKey();


        }

        public override void Informasao()
        {
            base.Informasao();
        }
    }
}
