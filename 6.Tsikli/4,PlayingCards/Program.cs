using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    string color = "";
                    string card = "";
                    switch (i)
                    {
                        case 1: color = "спатия"; break;
                        case 2: color = "каро"; break;
                        case 3: color = "купа"; break;
                        case 4: color = "пика"; break;
                    }

                    switch (j)
                    {
                        case 2: card = "двойка"; break;
                        case 3: card = "тройка"; break;
                        case 4: card = "четворка"; break;
                        case 5: card = "петица"; break;
                        case 6: card = "шестица"; break;
                        case 7: card = "седмица"; break;
                        case 8: card = "осмица"; break;
                        case 9: card = "девятка"; break;
                        case 10: card = "десятка"; break;
                        case 11: card = "вале"; break;
                        case 12: card = "дама"; break;
                        case 13: card = "поп"; break;
                        case 14: card = "асо"; break;
                        
                    }
                    Console.WriteLine(card + " " + color + "  ");
                }
                Console.WriteLine();

            }
        }
    }
}
