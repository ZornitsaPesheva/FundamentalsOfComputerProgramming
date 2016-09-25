using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaxSubarrayOfGrowingNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 6, 2, 3, 4, 3, 4, 5, 6, 4, 5, 6 };
            int currentStart = 0;
            int currentLenght = 1;
            int longestStart = 0;
            int longestLenght = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > longestLenght)
                    {
                        longestLenght = currentLenght;
                        longestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLenght = 1;
                }
            }
            for (int i = longestStart; i < longestLenght + longestStart; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
    }
}
