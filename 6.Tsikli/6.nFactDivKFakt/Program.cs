using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.nFactDivKFakt
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
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
            Console.WriteLine(nTest);
            Console.WriteLine(kTest);
            Console.WriteLine(nTest / kTest);
            k = k + 1;
            for (int i = k + 1; i <= n; i++)
            {
                k *= i;
            }
            Console.WriteLine(k);
        }
    }
}
