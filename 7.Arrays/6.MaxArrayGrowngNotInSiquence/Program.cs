using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaxArrayGrowngNotInSiquence
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 9 };
            int[] len = new int[10];
            for (int x = 0; x < arr.Length; x++)
            {
                int prev = 0;
                for (int i = 0; i <= x; i++)
                {
                    if (arr[x] > arr[i])
                    {
                        prev = i;
                    }
                }
                if (prev != 0)
                {
                    len[x] = 1 + len[prev];
                }
                else
                {
                    len[x] = 1;
                }
            }
            if (arr[arr.Length - 1] > arr[arr.Length - 2])
            {
                len[arr.Length - 1] = len[arr.Length - 2];
            }
            for (int i = 0; i < len.Length - 1; i++)
            {
                 Console.WriteLine(len[i]);
            }
        }
    }
}
