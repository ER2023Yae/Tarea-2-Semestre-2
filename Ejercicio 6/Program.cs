using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numerosinsanos = { 5, 2, 8, 3, 1 };

            string[] PalabrasInsanas = { "mno", "jkl", "abc", "def", "ghi" };
            Class1 sorter = new Class1();


            Console.WriteLine("Arreglo de números original:");

            PonerArray(numerosinsanos);


            sorter.Sort(numerosinsanos);


            Console.WriteLine("Arreglo de números ordenado:");

            PonerArray(numerosinsanos);


            Console.WriteLine("Arreglo de palabras original:");

            PonerArray(PalabrasInsanas);


            sorter.Sort(PalabrasInsanas);


            Console.WriteLine("Arreglo de palabras ordenado:");

            PonerArray(PalabrasInsanas);
            Console.ReadKey();
        }

        static void PonerArray<T>(T[] array)

        {

            foreach (T item in array)

            {

                Console.Write(item + " ");

            }

            Console.WriteLine();

        }
        
    }
}
