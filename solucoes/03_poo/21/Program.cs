using System;

namespace LP1Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate player and npc
            Player player = new Player();
            NPC npc = new NPC();

            // Test Move methods from both classes
            Console.WriteLine("Player Direction: "+ player.Move());
            Console.WriteLine("NPC Direction: " + npc.Move());
        }
    }
}
