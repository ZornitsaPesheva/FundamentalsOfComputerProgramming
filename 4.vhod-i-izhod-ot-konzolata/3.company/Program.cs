using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            var name = Console.ReadLine();
            Console.Write("Company address: ");
            var address = Console.ReadLine();
            Console.Write("Company phone: ");
            var phone = Console.ReadLine();
            Console.Write("fax: ");
            var fax = Console.ReadLine();
            Console.Write("site: ");
            var site = Console.ReadLine();
            Console.WriteLine("manager ");
            Console.Write("first name: ");
            var firstName = Console.ReadLine();
            Console.Write("second name: ");
            var secondName = Console.ReadLine();
            Console.Write("phone: ");
            var managerPhone = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(phone);
            Console.WriteLine(fax);
            Console.WriteLine(site);
            Console.WriteLine();
            Console.WriteLine(firstName);
            Console.WriteLine(secondName);
            Console.WriteLine(managerPhone);
        }
    }
}
