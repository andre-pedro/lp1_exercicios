using System;

namespace LP1_Exercises
{
    public class Player : Character
    {
        public override char Move()
        {
            // Variable to hold player input
            string input = "";
            // Variable to hold direction
            char dir = ' ';

            // Ask for user input
            Console.Write("Please enter a direction: ");
            // Get user input
            input = Console.ReadLine();

            // Choose direction based on user input
            switch (input.ToLower())
            {
                // if user input is 'W' or 'w'
                // Direction is North
                case "w":
                    dir = 'N';
                    break;
                // if user input is 'S' or 's'
                // Direction is South
                case "s":
                    dir = 'S';
                    break;
                // if user input is 'A' or 'a'
                // Direction is West
                case "a":
                    dir = 'W';
                    break;
                // if user input is 'D' or 'd'
                // Direction is East
                case "d":
                    dir = 'E';
                    break;
            }

            // Returns direction
            return dir;
        }
    }
}