using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ChangePtoV
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var v = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int x = ((n & mask) != 0 ? 1 : 0);
            if (x == 1 && v == 0)
                n = n & (~(1 << p));
            else if (x == 0 && v == 1)
                n = n | (1 << p);
            Console.WriteLine(n);
        }
    }
}
