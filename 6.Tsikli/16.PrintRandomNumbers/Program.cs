using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
            }
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
       
                int j = rnd.Next(0, n);
                int k = rnd.Next(0, n);
                var x = 0;  
      
                x = numbers[j];
                numbers[j] = numbers[k];
                numbers[k] = x;
                Console.WriteLine(numbers[j]);
                Console.WriteLine(numbers[k]);
                Console.WriteLine();
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
