using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeLadderLogic
    {
        public void SnakLadder()
        {
            //UC1-ZeroPosition

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("--------Welcome Game Snake-Ladder------");
            Console.WriteLine("---------------------------------------");
            int Player1 = 0;
            //Console.WriteLine("Your position is : " + Position);

            //UC2-Random number generater for dice value

            Console.WriteLine("enter your name here");
            string Name = Console.ReadLine();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---welcome : " + Name + " to Snake & Ladder----");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("-----Press enter for start the game----");
            Console.ReadLine();

            Console.WriteLine("Starts with single player position : " + Player1);
            Console.ReadLine();

            Random random = new Random();
            int dice = random.Next(0, 7);

            Console.WriteLine("dice value for player1 : " + dice);
        }
    }
}
