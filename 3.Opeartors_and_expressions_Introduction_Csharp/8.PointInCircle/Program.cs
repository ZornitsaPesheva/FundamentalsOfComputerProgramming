using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the pint in the circle ((0,0), 5)");
            Console.Write("x = ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            var y = int.Parse(Console.ReadLine());
            if ((x * x) + (y * y) <= 25)
                Console.WriteLine("The point is in the circle");
            else
                Console.WriteLine("The point is not in the circle");
        }
    }
}
