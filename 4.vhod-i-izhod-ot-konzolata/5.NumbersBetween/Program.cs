using System;

namespace _5.NumbersBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 5 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
