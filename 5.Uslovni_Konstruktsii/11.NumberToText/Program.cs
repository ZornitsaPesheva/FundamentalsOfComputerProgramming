using System;

namespace _11.NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string a = "";
            string b = "";
            string c = "";
            switch (n % 10)
            {
                case 1: c = "едно"; break;
                case 2: c = "две"; break;
                case 3: c = "три"; break;
                case 4: c = "четири"; break;
                case 5: c = "пет"; break;
                case 6: c = "шест"; break;
                case 7: c = "седем"; break;
                case 8: c = "осем"; break;
                case 9: c = "девет"; break;
            }
            switch (n % 100)
            {
                case 10: b = "десет"; break;
                case 11: b = "единадесет"; break;
                case 12: b = "дванадесет"; break;
                case 13: b = "тринадесет"; break;
                case 14: b = "четеринадесет"; break;
                case 15: b = "петнадесет"; break;
                case 16: b = "шеснадесет"; break;
                case 17: b = "седемнадесет"; break;
                case 18: b = "осемнадесет"; break;
                case 19: b = "деветнадесет"; break;
            }
            switch ((n % 100) / 10)
            {
                case 2: b = "двадесет"; break;
                case 3: b = "тридесет"; break;
                case 4: b = "четирдесет"; break;
                case 5: b = "петдесет"; break;
                case 6: b = "шестдесет"; break;
                case 7: b = "седемдесет"; break;
                case 8: b = "осемдесет"; break;
                case 9: b = "деветдесет"; break;
            }
            switch (n / 100)
            {
                case 1: a = "сто"; break;
                case 2: a = "двеста"; break;
                case 3: a = "триста"; break;
                case 4: a = "четиристотин"; break;
                case 5: a = "петстотин"; break;
                case 6: a = "шестстотин"; break;
                case 7: a = "седемстотин"; break;
                case 8: a = "осемстотин"; break;
                case 9: a = "деветстотин"; break;
            }

            if (n == 0)
            {
                Console.WriteLine("нула");
            }
            else if (n < 10)
            {
                Console.WriteLine(c);
            }
            else if (n >= 10 && n <= 19)
            {
                Console.WriteLine(b);
            }
            else if (n > 19 && n <= 99)
            {
                if (n % 10 == 0)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(b + " и " + c);
                }
            }
            else if (n >= 100 && n <= 999)
            {
                if (n % 100 == 0)
                {
                    Console.WriteLine(a);
                }
                else if (n % 10 == 0)
                {
                    Console.WriteLine(a + " и " + b);
                }
                else if (n % 100 >= 10 && n % 100 <= 20)
                {
                    Console.WriteLine(a + " и " + b);
                }
                else
                {
                    Console.WriteLine(a + " " + b + " и " + c);
                }
             
            }
        }
    }
}
