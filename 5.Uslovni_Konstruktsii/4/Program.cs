using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            if (b < a)
            {
                if (c < b)
                {
                    var x = a;
                    a = c;
                    c = x;
                }
                else
                {
                    var x = a;
                    a = b;
                    b = x;
                }
            }
            else if (c < a)
            {
                var x = a;
                a = c;
                c = x;
                x = b;
                b = c;
                c = x;
            }
            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}
