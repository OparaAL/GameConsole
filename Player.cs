using System;

namespace GameConsole
{
    public class Player
    {
        public int Health { set; get; }
        public int MaxHealth { set; get; }
        public bool IsComputer { set; get; }
        public string Type { set; get; }

        public Player(bool isComputer, int health)
        {
            if (isComputer)
            {
                this.Type = "Computer";
                this.IsComputer = isComputer;
            }
            else
            { 
                this.Type = "Player";
                this.IsComputer = isComputer;
            }
            this.Health = health;
            this.MaxHealth = health;
        }


        public void LowRangeAttack(Player target)
        {
            Random random = new Random();
            int damage = random.Next(18,25);
            target.Health -= damage;
            Console.WriteLine(this.Type + " deals " + damage + " damage by low range attack to " + target.Type+ ".");
        }

        public void HighRangeAttack(Player target)
        {
            Random random = new Random();
            int damage = random.Next(10, 35);
            target.Health -= damage;
            Console.WriteLine(this.Type + " deals " + damage + " damage by high range attack to " + target.Type + ".");
        }

        public void Heal()
        {
            if (this.Health != this.MaxHealth) // If object health is not full, object heals
            {
                Random random = new Random();
                int heal = random.Next(18, 25);
                this.Health += heal;
                if (this.Health > this.MaxHealth) this.Health = 100;
                Console.WriteLine(this.Type + " heals " + heal + " points of health.");
            }
            else Console.WriteLine(this.Type +" action is heal, but"
                + " health is full."); // If object health if full, object doesnt heals
        }

        //Generate random action for player or computer
        public void Action(Player player, Player computer, double check)
        {
            if(check < 30)
            { 
                    if (!this.IsComputer) LowRangeAttack(computer);
                    else LowRangeAttack(player);
            }
            if(check >= 30 && check < 60)
            { 
                    if (!this.IsComputer) HighRangeAttack(computer);
                    else HighRangeAttack(player);
            }
            if(check >= 60)
            { 
                    Heal();
            }
        }
    }
}
