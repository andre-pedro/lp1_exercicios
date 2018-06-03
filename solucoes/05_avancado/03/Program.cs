using System;

namespace LP1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new instance of class HighScoreManager
            HighScoreManager hsm = new HighScoreManager();

            // Add scores as example
            hsm.AddScore("Bilbo", 1000f);
            hsm.AddScore("The Hound", 1052f);
            hsm.AddScore("Jon Snow", 2530f);
            hsm.AddScore("Legolas", 123f);
            hsm.AddScore("Frodo", 567f);
            hsm.AddScore("Dumbledore", 235f);
            hsm.AddScore("Potter", 623f);

            // Save scores to file
            hsm.Save();

            // Print on console all scores on file using ToString()
            Console.WriteLine(hsm);

            // Print all Names and Scores in the list using GetScores()
            foreach (Tuple<string, float> highscore in hsm.GetScores())
            {
                Console.WriteLine($"Name: {highscore.Item1,-14}      " +
                    $"Score:{highscore.Item2,-14}");
            }
        }
    }
}
