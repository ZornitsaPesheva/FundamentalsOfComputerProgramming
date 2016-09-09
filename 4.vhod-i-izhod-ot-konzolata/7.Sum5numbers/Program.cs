using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum5numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            
            for (int i = 0; i < 5; i++)
                
            {
                bool b = false;
                while (b == false)
                    b = int.TryParse(Console.ReadLine(), out arr[i]);
            }
            Console.WriteLine(arr[0] + arr[1] + arr[2] + arr[3] + arr[4]);
        }
    }
}
