using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IsTheBit1
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            Console.WriteLine((v & mask) != 0 ? true : false);
        }
    }
}
