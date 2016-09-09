using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CalcSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            double sum = 1;
            for (int i = n; i >= 1; i--)
            {
     
                var fact = i;
                for (int j = i - 1; j >= 1; j--)
                {
                    fact = fact * j;
                }
           //     Console.WriteLine(fact);
                var x1 = 1;
                for (int k = 1; k <= i; k++)
                {
                    x1 = x1 * x;
                }
         //       Console.WriteLine(x1);
                sum = sum + ((double)fact / x1);
            }
            Console.WriteLine(sum);
        }
    }
}
