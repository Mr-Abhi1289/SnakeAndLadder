using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class StartGame
    {


        Random random = new Random();
        public void RollDie()
        {
            int dice = random.Next(1, 7);
            Console.WriteLine(dice);
        }

    }
    
}
