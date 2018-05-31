using System;

namespace LP1_Exercises
{
    public class NPC : Character
    {
        // Overriding the method Move() from Character Class
        public override char Move()
        {
            // Get a random instance
            Random r = new Random();
            // Temp variable to hold direction
            char dir = ' ';

            // Get a random number and choose direction based on it
            switch (r.Next(1, 5))
            {
                // Random number is 1
                case 1:
                    // Direction is North
                    dir = 'N';
                    break;
                // Random number is 2
                case 2:
                    // Direction is South
                    dir = 'S';
                    break;
                // Random number is 3
                case 3:
                    // Direction is East
                    dir = 'E';
                    break;
                // Random number is 4
                case 4:
                    // Direction is West
                    dir = 'W';
                    break;
            }

            // Returns direction
            return dir;
        }
    }
}
