using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolko_i_krzyzyk
{
    static class Game
    {
        static public void WithPlayer()
        {
            int possition;
            String Playername1, Playername2;
            Map map = new Map();


            Console.Write("\n\nPodaj imię pierwszego gracza (X): ");
            Playername1 = Console.ReadLine();

            Console.Write("\n\nPodaj imię drugiego gracza (O): ");
            Playername2 = Console.ReadLine();

            Players player1 = new Players('X', Playername1);
            Players player2 = new Players('O', Playername2);


            map.DrawMap();

            do
            {
                possition = player1.getField(player1);
                map.PutSign(possition, player1);
                map.DrawMap();
                if (map.CheckResultGame(player1) == true)
                {
                    break;
                }
                Console.Clear();
                map.DrawMap();
                possition = player2.getField(player2);
                map.PutSign(possition, player2);
                Console.Clear();
                map.DrawMap();
            } while (!(map.CheckResultGame(player2)));
        }






        static public void WithComputer()
        {
            int possition;
            String Playername1;
            Map map = new Map();

            Console.Write("\n\nPodaj imię pierwszego gracza (X): ");
            Playername1 = Console.ReadLine();

            Players player1 = new Players('X', Playername1);
            Players computer = new Players('O', "Komputer");


            map.DrawMap();

            do
            {
                possition = player1.getField(player1);
                map.PutSign(possition, player1);
                map.DrawMap();
                if (map.CheckResultGame(player1) == true)
                {
                    break;
                }
                Console.Clear();
                map.DrawMap();
                possition = computer.getComputersField();
                map.PutSign(possition, computer);
                Console.Clear();
                map.DrawMap();
            } while (!(map.CheckResultGame(computer)));

        }


    }
}
