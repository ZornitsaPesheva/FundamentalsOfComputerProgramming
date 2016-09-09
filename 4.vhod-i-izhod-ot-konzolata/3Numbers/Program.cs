using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = (Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:X,10} {1,10} {2,10}", a, Math.Round(b, 2), Math.Round(-c, 2));
        }
    }
}
