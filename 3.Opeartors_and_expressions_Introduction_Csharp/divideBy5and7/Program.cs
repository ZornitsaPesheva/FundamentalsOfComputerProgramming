using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divideBy5and7
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            if (x % 7 == 0 && x % 5 == 0)
                Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
