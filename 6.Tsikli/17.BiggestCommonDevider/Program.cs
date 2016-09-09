using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.BiggestCommonDevider
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                var t = n;
                n = m % n;
                m = t;
            }
            Console.WriteLine(m);
        }
    }
}
