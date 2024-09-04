using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class figura1
    {
        public string Nombre;
        public string Color;

        public figura1(string nombre, string color)
        {
            Nombre = nombre;
            Color = color;
        }



        public virtual void CalcularArea()
        {


        }

        public virtual void CalcularPerimetro()
        {


        }

        public virtual void Informasao()
        {
            Console.WriteLine("El nombre de la figura es " + Nombre + " y su color es " + Color);
            Console.ReadKey();

        }

    }
}
