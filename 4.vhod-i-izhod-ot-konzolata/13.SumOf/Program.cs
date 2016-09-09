using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SumOf
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 1;
            double sum = 1;
            double oldsum = 0;
            while (Math.Abs(sum - oldsum) > 0.001)
            {
                if ((n + 1) % 2 == 0)
                {
                    oldsum = sum;
                    sum = sum + 1 / (n + 1);
                    n++;
                }
                else
                {
                    oldsum = sum;
                    sum = sum - 1 / (n + 1);
                    n++;
                }
            }
            Console.WriteLine(oldsum); // старата сума
            Console.WriteLine(sum); //натрупаната сума
            Console.WriteLine(sum - oldsum); // разликата е по-малка от 0.001
        }
    }
}
