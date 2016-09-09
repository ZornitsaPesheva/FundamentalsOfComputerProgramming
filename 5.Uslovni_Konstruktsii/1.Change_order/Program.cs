using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Change_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете 2 цели числа:");
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            if (m > n)
            {
                var x = n;
                n = m;
                m = x;
            }
            Console.WriteLine(m + " " + n);
        }
    }
}
