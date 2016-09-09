using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string str = "";
            while (n / 2 != 0)
            {
                str = str + (n % 2);
                n = n / 2;
            }
            if (n % 2 == 1)
            {
                str = str + 1;
            }
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
