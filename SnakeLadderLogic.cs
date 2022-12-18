using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeLadderLogic
    {
        public static void snake()
        {
            //constant

            int LADDER = 1;
            int SNAKE = 2;
            int Player1 = 0;

            //for dice
            int CurrentPosition = 0;
            Random random1 = new Random();
            int Move = random1.Next(1, 7);

            Console.WriteLine("---WELCOME TO SANKE & LADDER--");
            Console.WriteLine("------------------------------");

            Console.WriteLine("enter your name here");
            string Name = Console.ReadLine();
            Console.WriteLine("welcome : " + Name);
            Console.WriteLine("Press enter for start the game");
            Console.ReadLine();
            Random random = new Random();
            //computation
            int x = random.Next(0, 3);
            if (x == SNAKE)
            {
                Console.WriteLine("snake");
                CurrentPosition += Move;
            }
            else if (x == LADDER)
            {
                Console.WriteLine("Ladder");
                CurrentPosition -= Move;
            }
            else
            {
                Console.WriteLine("No Paly");
            }
        }
            
    }
}
