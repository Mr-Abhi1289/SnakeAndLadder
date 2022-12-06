using System;
using System.Security;

namespace SnakeAndLadder
{
    class Program
    {
        public const int START_POS = 0, FINISH_POS = 100;
        public static Random random = new Random();
        public static int DiceRoll()
        {
            return random.Next(1, 6);
        }
        static void Main(string[] args)
        {
            int currentPosition = START_POS;
            int numOnDice = DiceRoll();
            Console.WriteLine("number on the dice=" + numOnDice);
            Console.WriteLine("player poasition="+currentPosition);
        }
    }
}