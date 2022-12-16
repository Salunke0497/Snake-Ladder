using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeLadderLogic
    {
        public static void snake()
        {
            int Palyer1 = 0;
            Console.WriteLine("WELCOME TO SANKE & LADDER");            
            
            Console.WriteLine("enter your name here");
            string Name = Console.ReadLine();
            Console.WriteLine("welcome : " + Name + " into Snake & Ladder");
            Console.WriteLine("Press enter for start the game");
            Console.WriteLine("Starts with single player position : " + Palyer1);
            Console.ReadLine();
            Random random = new Random();
            int x = random.Next(0, 7);
            Console.WriteLine("dice value for player1 : " + x);
        }
    }
}
