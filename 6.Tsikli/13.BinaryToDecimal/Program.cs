using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var sum = 0;
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                
                var x = 1;
                for (int k = 1; k <= j; k++)
                {
                    x = x * 2;
                }
                sum = sum + ((int)Char.GetNumericValue(str[i]) * x);
            }
            Console.WriteLine(sum);
        }
    }
}
