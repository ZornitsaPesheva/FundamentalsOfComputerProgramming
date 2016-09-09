using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Factoriels
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var nMinusK = n - k;
            var kTest = k;
            var nTest = n;
            for (int i = nTest - 1; i >= 1; i--)
            {
                nTest *= i;
            }
            for (int i = kTest - 1; i >= 1; i--)
            {
                kTest *= i;
            }
            for (int i = nMinusK - 1; i >= 1; i--)
            {
                nMinusK *= i;
            }
            Console.WriteLine(nTest);
            Console.WriteLine(kTest);
            Console.WriteLine(nTest * kTest / nMinusK);
            var fact = n - k + 1;
            for (int i = n - k + 2; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact * kTest);
        }
    }
}
