using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IsNumberSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            bool simple = true;
            for (int i = 2; i <= Math.Sqrt(x); i++)
                if ((x % i) == 0) simple = false;
            Console.WriteLine(simple);
        }
    }
}
