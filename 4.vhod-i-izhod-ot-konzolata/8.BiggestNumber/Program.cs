using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine(max);
        }
    }
}
