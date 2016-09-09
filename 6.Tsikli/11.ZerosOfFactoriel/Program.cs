using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ZerosOfFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            for (long i = n - 1; i >= 1; i--)
            {
                n *= i;
            }
            var zeroes = 0;
            Console.WriteLine(n);
            while (n % 10 == 0)
            {
                zeroes++;
                n = n / 10;
            }
            Console.WriteLine(zeroes);
        }
    }
}
