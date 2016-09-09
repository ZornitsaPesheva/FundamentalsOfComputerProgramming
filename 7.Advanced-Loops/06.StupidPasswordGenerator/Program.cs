using System;

namespace _06.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int i2 = 1; i2 < n; i2++)
                {
                    char firstLetter = 'a';
                    for (int j = 1; j <= l; j++)

                    {
                        char secondLetter = 'a';
                        for (int m = 1; m <= l; m++)
                        {
                            for (int k = i + 1; k <= n; k++)
                            {
                                if (k > i && k > i2)
                                    Console.Write(i.ToString() + i2 + firstLetter.ToString() + secondLetter.ToString() + k + " ");
                            }
                            secondLetter++;
                        }
                        firstLetter++;
                    }
                }

                
            }
        }
    }
}
