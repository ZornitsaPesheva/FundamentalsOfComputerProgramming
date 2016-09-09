using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kingoffthieves
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            int inner = 1;
            int leftdashes = (n - inner) / 2;
            int rightdashes = (n - inner) / 2;


            for (int i = 0; i < n / 2; i++)
            {
                for (int col = 0; col < leftdashes; col++)
                {
                    Console.Write("-");
                }
                for (int a = 0; a < inner; a++)
                {
                    Console.Write(symbol);
                }
                for (int col = 0; col < rightdashes; col++)
                {
                    Console.Write('-');
                }
                leftdashes--;
                inner++;
                inner++;
                rightdashes--;


                Console.WriteLine();
            }


            for (int i = 0; i < n; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();


            leftdashes = 1;
            rightdashes = 1;
            inner = n - (leftdashes + rightdashes);
            for (int i = 0; i < n / 2; i++)
            {
                for (int col = 0; col < leftdashes; col++)
                {
                    Console.Write("-");
                }
                for (int a = 0; a < inner; a++)
                {
                    Console.Write(symbol);
                }
                for (int col = 0; col < rightdashes; col++)
                {
                    Console.Write('-');
                }

                leftdashes++;
                inner--;
                inner--;

                rightdashes++;



                Console.WriteLine();
            }



        }
    }
}