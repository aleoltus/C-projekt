using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolko_i_krzyzyk
{
    class Map
    {
        public static char[] ArrayMap;





        public Map()
        {
            ArrayMap = new char[9];     // Tworzy tablicę 9-cio elementową

            for (int i = 0; i < 9; i++)
            {
                ArrayMap[i] = ' ';
            }
        }





        public void DrawMap()
        {
            Console.Write("\n\t\t\t\t\t\t\t\t\t1 2 3\n\n\t\t\t\t\t\t\t\t\t4 5 6\n\n\t\t\t\t\t\t\t\t\t7 8 9\n");
            for (int i = 0; i < ArrayMap.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("\n\t\t\t\t\t\t\t-------------");
                    Console.Write("\n\t\t\t\t\t\t\t|");
                }
                Console.Write(" {0} |", ArrayMap[i]);
            }
            Console.Write("\n\t\t\t\t\t\t\t-------------");
        }





        public void PutSign(int possition, Players player)
        {
            ArrayMap[possition] = player.sign;        // wpisuje znak do tablicy
        }






        public bool CheckResultGame(Players player)
        {
            if((ArrayMap[0] == player.sign && ArrayMap[1] == player.sign && ArrayMap[2] == player.sign) ||
               (ArrayMap[0] == player.sign && ArrayMap[3] == player.sign && ArrayMap[6] == player.sign) ||
               (ArrayMap[0] == player.sign && ArrayMap[4] == player.sign && ArrayMap[8] == player.sign) ||
               (ArrayMap[1] == player.sign && ArrayMap[4] == player.sign && ArrayMap[7] == player.sign) ||
               (ArrayMap[2] == player.sign && ArrayMap[5] == player.sign && ArrayMap[8] == player.sign) ||
               (ArrayMap[2] == player.sign && ArrayMap[4] == player.sign && ArrayMap[6] == player.sign) ||
               (ArrayMap[3] == player.sign && ArrayMap[4] == player.sign && ArrayMap[5] == player.sign) ||
               (ArrayMap[6] == player.sign && ArrayMap[7] == player.sign && ArrayMap[8] == player.sign))
            {
                Console.Write("\n\nWYGRAŁ GRACZ O IMIENIU: {0} (znak {1})\n\n",player.name, player.sign);
                return true;
            }


            int counter = 0;


            for (int i = 0; i < ArrayMap.Length; i++)
            {
                

                if (ArrayMap[i] != ' ')
                {
                    counter++;
                }

                if(counter == 9)
                {
                    Console.Write("\n\nREMIS!\n\n");
                    return true;
                }
            }

            return false;
        }

    }
}
