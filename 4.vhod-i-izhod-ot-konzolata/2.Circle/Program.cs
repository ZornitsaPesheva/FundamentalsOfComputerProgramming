using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("лице: " + Math.PI * r * r);
            Console.WriteLine("периметър: " + Math.PI * r * 2);
        }
    }
}
