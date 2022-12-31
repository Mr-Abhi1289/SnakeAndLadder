namespace SnakeAndLadder
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                StartGame SG = new StartGame();
                int player1 = SG.RollDie();
                StartGame SG1 = new StartGame();
                int player2 = SG1.RollDie();
                Console.WriteLine("Player 1  total number dice roll is  " + player1);
                Console.WriteLine("Player 2  total number dice roll is  " + player2);
                int num1 = player1.CompareTo(player2);
                if (num1 == 0)
                {
                    Console.WriteLine("Game is Tie");
                }
                if (num1 == 1)
                {
                    Console.WriteLine("Player 1 Wins the match");
                }
                else
                {
                    Console.WriteLine("Player 2 Wins the match");
                }
            }
        }
    }