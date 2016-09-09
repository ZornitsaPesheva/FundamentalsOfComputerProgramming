using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var temp = 0;
            for (int i = 1; i <= n; i++)
            {
                
                var temp1 = temp;
                for (int j = 1; j <= n ; j++)
                {
                    temp1++;
                    Console.Write(temp1 + " ");
                }
                temp++;
                Console.WriteLine();
            }
        }
    }
}
