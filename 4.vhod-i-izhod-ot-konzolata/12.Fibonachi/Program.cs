using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = 0;
            ulong m = 1;
            ulong k = 0;
            Console.WriteLine(n);
            Console.WriteLine(m);
            for (int i = 1; i <= 100; i++)
            {
                k = n + m; 
                n = m;
                m = k;
                Console.WriteLine(k);
            }
            
        }
    }
}
