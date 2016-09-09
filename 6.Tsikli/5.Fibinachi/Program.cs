using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibinachi
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prepre = 0;
            var pre = 1;
            Console.WriteLine(prepre);
            Console.WriteLine(pre);
            for (int i = 1; i <= n; i++)
            {
                var fib = prepre + pre;
                Console.WriteLine(fib);
                prepre = pre;
                pre = fib;
                
            }
        }
    }
}
