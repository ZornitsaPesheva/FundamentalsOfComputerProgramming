using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.signOfresult
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var minuses = 0;
            if (a < 0)
            {
                minuses = minuses + 1;
            }
            if (b < 0)
            {
                minuses = minuses + 1;
            }
            if (c < 0)
            {
                minuses = minuses + 1;
            }
            if (minuses == 2)
            {
                Console.WriteLine("+");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }   
        }
    }
}
