using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is3rdDigit7
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = x / 100;
            var z = y % 10;
            if (z == 7)
                Console.WriteLine("The 3rd number is 7");
            else
                Console.WriteLine("The 3rd number is not 7");
        }
    }
}
