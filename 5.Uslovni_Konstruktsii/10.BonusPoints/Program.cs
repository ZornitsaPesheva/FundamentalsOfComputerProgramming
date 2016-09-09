using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                case 2:
                case 3:
                    p *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    p *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    p *= 1000;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine(p);
         }
    }
}
