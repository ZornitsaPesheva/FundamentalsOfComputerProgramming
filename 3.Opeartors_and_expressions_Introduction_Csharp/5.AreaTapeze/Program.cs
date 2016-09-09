using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AreaTapeze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate rapeze area");
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("the prapeze area is " + (a + b) / 2 * b);
        }
    }
}
