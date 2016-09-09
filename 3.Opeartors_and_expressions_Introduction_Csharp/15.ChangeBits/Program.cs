using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ChangeBits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int p3 = (n & (1 << 3)) != 0 ? 1 : 0;
            int p4 = (n & (1 << 4)) != 0 ? 1 : 0;
            int p5 = (n & (1 << 5)) != 0 ? 1 : 0;
            int p24 = (n & (1 << 24)) != 0 ? 1 : 0;
            int p25 = (n & (1 << 25)) != 0 ? 1 : 0;
            int p26 = (n & (1 << 26)) != 0 ? 1 : 0;
            if (p24 == 1)
                n = n | (1 << 3);
            else
                n = n & (~(1 << 3));
            if (p25 == 1)
                n = n | (1 << 4);
            else
                n = n & (~(1 << 4));
            if (p26 == 1)
                n = n | (1 << 5);
            else
                n = n & (~(1 << 5));
            if (p3 == 1)
                n = n | (1 << 24);
            else
                n = n & (~(1 << 24));
            if (p4 == 1)
                n = n | (1 << 25);
            else
                n = n & (~(1 << 25));
            if (p5 == 1)
                n = n | (1 << 26);
            else
                n = n & (~(1 << 26));
            Console.WriteLine(n);
        }
    }
}
