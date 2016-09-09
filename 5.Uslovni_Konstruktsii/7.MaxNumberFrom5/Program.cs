using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MaxNumberFrom5
{
    class Program
    {
        static void Main(string[] args)
        {
            var i1 = double.Parse(Console.ReadLine());
            var i2 = double.Parse(Console.ReadLine());
            var i3 = double.Parse(Console.ReadLine());
            var i4 = double.Parse(Console.ReadLine());
            var i5 = double.Parse(Console.ReadLine());
            var maxNum = i1;
            if (i2 > maxNum)
            {
                maxNum = i2;
            }
            if (i3 > maxNum)
            {
                maxNum = i3;
            }
            if (i4 > maxNum)
            {
                maxNum = i4;
            }
            if (i5 > maxNum)
            {
                maxNum = i5;
            }
            Console.WriteLine(maxNum);
        }
    }
}
