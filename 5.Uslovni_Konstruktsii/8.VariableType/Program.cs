using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.VariableType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете тип променлива:");
            Console.WriteLine("0 за int, 1 за double и 2 за string");
            
            var t = int.Parse(Console.ReadLine());
            switch (t)
            {
                case 0:
                    var n = int.Parse(Console.ReadLine());
                    n++;
                    Console.WriteLine(n);
                    break;
                case 1:
                    var m = double.Parse(Console.ReadLine());
                    m++;
                    Console.WriteLine(m);
                    break;
                case 2:
                    var k = Console.ReadLine();
                    k += "*";
                    Console.WriteLine(k);
                    break;
            }
       
        }
    }
}
