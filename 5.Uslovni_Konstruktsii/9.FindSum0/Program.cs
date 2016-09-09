using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.FindSum0
{
    class Program
    {
        static void Main(string[] args)
        {
            var i1 = int.Parse(Console.ReadLine());
            var i2 = int.Parse(Console.ReadLine());
            var i3 = int.Parse(Console.ReadLine());
            var i4 = int.Parse(Console.ReadLine());
            var i5 = int.Parse(Console.ReadLine());

            if (i1 == 0)
            {
                Console.WriteLine("{0} e равно на 0", i1);
            }
            if (i1 + i2 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i1, i2);
            }
            if (i1 + i2 + i3 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", i1, i2, i3);
            }
            if (i1 + i2 + i4 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", i1, i2, i4);
            }
            if (i1 + i2 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", i1, i2, i4);
            }
            if (i1 + i2 + i3 + i4 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", i1, i2, i3, i4);
            }
            if (i1 + i2 + i3 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", i1, i2, i3, i4);
            }
            if (i1 + i2 + i3 + i4 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", i1, i2, i3, i4);
            }
            if (i1 + i3 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i1, i3);
            }
            if (i1 + i3 + i4 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", i1, i3, i4);
            }
            if (i1 + i3 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", i1, i3, i5);
            }
            if (i1 + i3 + i4 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", i1, i3, i4, i5);
            }
            if (i1 + i4 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i1, i4);
            }
            if (i1 + i4 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", i1, i4, i5);
            }
            if (i1 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i1, i5);
            }
            if (i2 == 0)
            {
                Console.WriteLine("{0} e равно на 0", i2);
            }
            if (i2 + i3 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i2, i3);
            }
            if (i2 + i3 + i4 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} e равно на 0", i2, i3, i4);
            }
            if (i2 + i3 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} e равно на 0", i2, i3, i5);
            }
            if (i2 + i3 + i4 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} e равно на 0", i2, i3, i4, i5);
            }
            if (i2 + i4 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i2, i4);
            }
            if (i2 + i4 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} e равно на 0", i2, i4, i5);
            }
            if (i2 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i2, i5);
            }
            if (i3 == 0)
            {
                Console.WriteLine("{0} e равно на 0", i3);
            }
            if (i3 + i4 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i3, i4);
            }
            if (i3 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i3, i4);
            }
            if (i3 + i4 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i3, i4, i5);
            }
            if (i4 == 0)
            {
                Console.WriteLine("{0} e равно на 0", i4);
            }
            if (i4 + i5 == 0)
            {
                Console.WriteLine("{0} + {1} e равно на 0", i4, i5);
            }
            if (i5 == 0)
            {
                Console.WriteLine("{0} e равно на 0", i5);
            }
        }
    }
}
