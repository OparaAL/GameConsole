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
            player.Health = 100;
            player.IsComputer = false;
            computer.Health = 100;
            computer.IsComputer = true;

            double check = 0;
            double move = 0;
            Random random = new Random();
            do
            {
                Console.WriteLine("New turn");
                move = random.Next(1, 100);
                if(move < 50)
                {
                    check = random.Next(1, 100);
                    player.Action(player, computer, check);
                }
                if(move >= 50)
                {
                    check = random.Next(1, 100);
                    if(check >= 30 && computer.Health <= 35)
                    {
                        check = check / 0.2;
                        computer.Action(player, computer, check);
                    }
                    else computer.Action(player, computer, check);

                }

                Console.WriteLine("Turn is over");
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
