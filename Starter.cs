using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class Starter
    {
        public void Start(Player player, Player computer)
        {
            double check = 0;// Defines which skill be used by object(player or computer)
            double move = 0; // Defines who makes next move
            Random random = new Random();
            do
            {
                Console.WriteLine("New move");
                move = random.Next(1, 100);
                if(move < 50)
                {
                    check = random.Next(1, 100);
                    player.Action(player, computer, check);
                }
                if(move >= 50)
                {
                    check = random.Next(1, 100);
                    if(check >= 30 &&
                        computer.Health <= (computer.MaxHealth * 35) / 100) // If computer health < 35%, increase chance of heal
                    {
                        check = check / 0.3; // Increasing chance of heal
                        computer.Action(player, computer, check);
                    }
                    else computer.Action(player, computer, check);
                }
                Console.WriteLine("Move is over");
                Console.WriteLine("Player health: " + player.Health + ". Computer health: " + computer.Health + ".");
                Console.WriteLine("------");
                move = 0;
                check = 0;
            }
            while (player.Health > 0 && computer.Health > 0);
            if (player.Health <= 0) Console.WriteLine("Computer wins");
            else Console.WriteLine("Player wins");
        }
    }
}
