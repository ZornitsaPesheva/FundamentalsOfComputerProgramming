using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Biggest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var maxNum = a;
            if (b > a)
            {
                if (c > b)
                {
                    maxNum = c;
                }
                else
                {
                    maxNum = b;
                }
            }
            else if (c > a)
            {
                maxNum = c;
            }
            Console.WriteLine(maxNum);
        }
    }
}
