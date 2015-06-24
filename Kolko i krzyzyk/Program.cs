// GRA KÓŁKO I KRZYŻYK
// VERSION 1.1

// - Dodana możliwość gry z komputerem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolko_i_krzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String choiceString;

            do
            {
                Console.Write("\n\n\t\tWYBIERZ TRYB GRY: \n\n");
                Console.Write("\t\t1. Player vs Player\n");
                Console.Write("\t\t2. Player vs Computer\n");
                Console.Write("\t\t0. Wyjście z programu\n");
                Console.Write("\n\n\t\tTwój wybór: ");

                choiceString = Console.ReadLine();
                choice = int.Parse(choiceString);

                switch (choice)
                {
                    case 1:
                        Game.WithPlayer();
                        break;
                    case 2:
                        Game.WithComputer();
                        break;
                    case 0:
                        break;
                }
            }while(choice != 0 || choice < 1 && choice > 2);

            Console.Write("\n\n\n\n\t\tŻYCZĘ MIŁEGO DNIA :)");
            Console.ReadKey();
        }
    }
}
