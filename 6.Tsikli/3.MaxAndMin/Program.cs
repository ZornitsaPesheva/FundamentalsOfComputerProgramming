using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int minNum = Int32.MaxValue;
            int maxNum = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < minNum)
                {
                    minNum = num;
                }
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine("Min number is " + minNum);
            Console.WriteLine("Max number is " + maxNum);
        }
    }
}
