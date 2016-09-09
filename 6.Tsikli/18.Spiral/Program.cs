using System;

namespace _18.Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n,n];
            int counter = 0;
            var fromrow = 0;
            var torow = n - 1;
            var fromcol = 0;
            var tocol = n - 1;
            do
            {
                for (int j = fromcol; j <= tocol; j++)
                {
                    counter++;
                    numbers[fromrow, j] = counter;
                }
                for (int i = fromrow + 1; i <= torow; i++)
                {
                    counter++;
                    numbers[i, tocol] = counter;
                }
                for (int j = tocol - 1; j >= fromcol; j--)
                {
                    counter++;
                    numbers[torow, j] = counter;
                }
                for (int i = torow - 1; i > fromrow; i--)
                {
                    counter++;
                    numbers[i, fromcol] = counter;
                }
                fromrow++;
                torow--;
                fromcol++;
                tocol--;
            } while (counter < n * n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ", numbers[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
