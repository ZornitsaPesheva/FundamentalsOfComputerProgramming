using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ActionsOn4digitsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var abcd = int.Parse(Console.ReadLine());
            var d = abcd % 10;
            var c = (abcd / 10) % 10;
            var b = (abcd / 100) % 10;
            var a = (abcd / 1000) % 10;
            Console.WriteLine("The sum of the munbers is " +
                (a + b + c + d));
            Console.WriteLine("back order: " + d + c + b + a);
            Console.WriteLine("last number on firt place " + d + a + b + c);
            Console.WriteLine("change 2nd and 3rd digit " + a + c + b + d);
        }
    }
}
