using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class StartGame
    {

        int Position = 0;
        Random random = new Random();


        public void RollDie()
        {
            while (Position < 101)
            {
                int num = random.Next(1, 7);
                int num1 = random.Next(0, 3);
                switch (num1)

                {
                    case 0:
                        Console.WriteLine("Player is in the same position");
                        break;
                    case 1:
                        Position += num;
                        Console.WriteLine("Player position is : " + Position);
                        break;
                    case 2:
                        Position -= num;
                        Console.WriteLine("Player position is : " + Position);
                        if (Position < 0)
                        {
                            Position = 0;
                            Console.WriteLine("Player position change to 0.So the player again Restart.");
                        }
                        break;
                }
            }
        }
    }
}

