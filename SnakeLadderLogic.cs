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
            int CurrentPosition = 0;
            //int Player1 = 0;

            Console.WriteLine("---WELCOME TO SANKE & LADDER--");
            Console.WriteLine("------------------------------");

            Console.WriteLine("enter your name here");
            string Name = Console.ReadLine();
            Console.WriteLine("welcome : " + Name);
            Console.WriteLine("Press enter for start the game");
            Console.ReadLine();

            while (CurrentPosition < 100)
            {
                //for dice                
                Random random1 = new Random();
                int Move = random1.Next(1, 7);

                Random random = new Random();
                int x = random.Next(0, 3);
                if (x == SNAKE)
                {
                    CurrentPosition -= Move;
                    Console.WriteLine("snake");
                    Console.WriteLine("CurrentPosition" + CurrentPosition);     
                    if (CurrentPosition < 0)
                    {
                        CurrentPosition = 0;
                    }
                }
                else if (x == LADDER)
                {
                    CurrentPosition += Move;
                    Console.WriteLine("Ladder");
                    Console.WriteLine("CurrentPosition" + CurrentPosition);
                    if (CurrentPosition > 100)
                    {
                        CurrentPosition -= Move;
                    }
                }
                else
                {
                    Console.WriteLine("No Paly");
                    Console.WriteLine("CurrentPosition" + CurrentPosition);

                }
            }
        }        
    }
}
