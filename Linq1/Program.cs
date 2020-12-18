

using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valoresNumerico = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("numero pares: ");

                List<int> numeroPares = new List<int>();
            /*
            foreach (int x in valoresNumerico) {

                if (x % 2 == 0) {
                    numeroPares.Add(x);
                }
         }
            foreach (int i in numeroPares) {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            IEnumerable<int> numerosPares = from numero in valoresNumerico where numero % 2 == 0 select numero;

             foreach (int i in numerosPares)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
