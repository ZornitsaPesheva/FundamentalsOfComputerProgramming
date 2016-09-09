using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Change_p_and_q_bites
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var q = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            //int[] ppoz = new int[2 * k];
            //int[] qpoz = new int[2 * k];
            Console.WriteLine();
            int[] arr = new int[64];
            //for (int i = 0; i < k; i++)
            //{
            //    ppoz[i] = p + i;
            //    qpoz[i] = q + i;
            //}

            for (int i = p; i < (p + k); i++)
            {
                arr[i] = (n & (1 << i)) != 0 ? 1 : 0;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();   

            for (int i = q; i < (q + k); i++)
            {
                arr[i] = (n & (1 << i)) != 0 ? 1 : 0;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            //for (int i = 0; i < 64; i++)
            //    Console.Write(arr[i]);
            Console.WriteLine();
            for (int i = 63; i >= 0; i--)
                Console.Write(arr[i]);
            var qx = q;
            for (int i = p; i < p + k; i++)
            {
                qx++;
                if (arr[i] == 1)
                    n = n | (1 << (qx));
                else
                    n = n & (~(1 << qx));
            }
                
            Console.WriteLine();
            Console.WriteLine(n);
            var px = p;
            for (int i = q; i < q + k; i++)
            {
                qx++;
                if (arr[i] == 1)
                    n = n | (1 << px++);
                else
                    n = n & (~(1 << px++));
            }

            Console.WriteLine();
            Console.WriteLine(n);
        }
    }
}
