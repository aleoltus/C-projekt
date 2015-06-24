using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolko_i_krzyzyk
{
    class Players
    {
        int possition;
        public char sign;
        public String name;

        
        
        public Players(char sign, String name)
        {
            this.sign = sign;
            this.name = name;
        }



        public int getField(Players player)
        {
            do
            {
                Console.Write("\n\n{0} podaj numer pola, w którym chcesz wstawić {1}  : ",name, sign);

                String possitionString = Console.ReadLine();
                possition = int.Parse(possitionString);
                possition--;
            } while (possition < 0 || possition > 8 || Map.ArrayMap[possition] == 'X' || Map.ArrayMap[possition] == 'O');


            return possition;
        }





        public int getComputersField()
        {
            Random generate = new Random();
            int possition;

            do
            {
                possition = generate.Next(0, 8);

            } while (possition < 0 || possition > 8 || Map.ArrayMap[possition] == 'X' || Map.ArrayMap[possition] == 'O');


            return possition;
        }
    }
}
