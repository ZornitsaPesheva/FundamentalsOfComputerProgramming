using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RectangleSquareAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate rectangle perimeter and area");
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter is " + (2 * a + 2 * b));
            Console.WriteLine("The area is " + (a * b));            
        }
    }
}
