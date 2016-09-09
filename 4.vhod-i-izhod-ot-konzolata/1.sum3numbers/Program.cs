using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.sum3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var a1 = Int32.Parse(a);
            var b = Console.ReadLine();
            var b1 = Int32.Parse(b);
            var c = Console.ReadLine();
            var c1 = Int32.Parse(c);
            Console.WriteLine(a1 + b1 + c1);
        }
    }
}
