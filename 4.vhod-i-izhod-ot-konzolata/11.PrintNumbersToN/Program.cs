using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintNumbersToN
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var m = Int32.Parse(n);
            for (int i = 1; i <= m; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
