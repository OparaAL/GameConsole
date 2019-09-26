using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(false,100);
            Player computer = new Player(true,100);
            Starter starter = new Starter();
            starter.Start(player, computer);
            Console.ReadKey();
        }
    }
}
