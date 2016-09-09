using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CatalansNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fact1 = 2 * n;
            for (int i = fact1 - 1; i >= 1; i--)
            {
                fact1 = fact1 * i;
            }

            var fact2 = n + 1;
            for (int i = fact2 - 1; i >= 1; i--)
            {
                fact2 = fact2 * i;
            }

            for (int i = n - 1; i >= 1; i--)
            {
                n = n * i;
            }

            Console.WriteLine(fact1 / (fact2 * n));
        }
    }
}
