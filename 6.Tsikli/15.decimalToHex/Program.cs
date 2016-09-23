using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.decimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var r = 0;
            char rs = 'a';
            string hex = "";
            do
            {
                r = n % 16;
                n /= 16;
                if (r >= 10)
                {
                    switch (r)
                    {
                        case 10: rs = 'A'; break;
                        case 11: rs = 'B'; break;
                        case 12: rs = 'C'; break;
                        case 13: rs = 'D'; break;
                        case 14: rs = 'E'; break;
                        case 15: rs = 'F'; break;
                    }
                    hex = rs.ToString() + hex;
                }
                else
                {
                    hex = r.ToString() + hex;
                }
            } while (n / 16 > 0);
            if (n != 0)
            {
                hex = n.ToString() + hex;
            }
            Console.WriteLine(hex);
        }
    }
}
