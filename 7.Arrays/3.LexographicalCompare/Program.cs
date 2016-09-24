using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LexographicalCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = { 'a', 'f', 'h' };
            char[] arr2 = { 'a', 'f', 'c' };
            int length = Math.Min(arr1.Length, arr2.Length);
            string first = "equal";
            for (int i = 0; i < length; i++)
            {
                if ((int)arr1[i] < (int)arr2[i])
                {
                    first = "arr1";
                }
                else if ((int)arr1[i] > (int)arr2[i])
                {
                    first = "arr2";
                }
                if (first != "equal")
                {
                    break;
                }
            }
            Console.WriteLine(first);
        }
    }
}
