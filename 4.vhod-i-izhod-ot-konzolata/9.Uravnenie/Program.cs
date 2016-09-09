using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Uravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете a, b и c:");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("Няма реални корени");
            }
            else if (d == 0)
            {
                Console.WriteLine(-(b / (2 * a)));
            }
            else
            {
                Console.WriteLine((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine((-b - Math.Sqrt(d)) / (2 * a));
            }
                
        }
    }
}
