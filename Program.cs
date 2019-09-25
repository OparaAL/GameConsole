using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(false);
            Player computer = new Player(true);
            Starter starter = new Starter();
            starter.Start(player, computer);
            Console.ReadKey();
        }
    }
}
