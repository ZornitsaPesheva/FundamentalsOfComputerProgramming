using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3rdBitIs1
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = int.Parse(Console.ReadLine());
            if ((i & 8) != 0)
                Console.WriteLine("The 3rd bit is 1");
            else
                Console.WriteLine("The 3rd bit id not 1");
        }
    }
}
