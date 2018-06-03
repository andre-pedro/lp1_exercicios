using System;
using System.Collections.Generic;
using System.IO;

namespace LP1Exercises
{
    public class HighScoreManager
    {
        // Create List to store highscores
        private List<Tuple<string, float>> highscores;

        // Constructor to initialize List
        public HighScoreManager(string filename = "HighScores.txt")
        {
            // If File does not exist, initialize empty list
            if (!File.Exists(filename)) highscores = new List<Tuple<string,
                float>>(10);
            // If file exists
            else
            {
                // Initialize List
                highscores = new List<Tuple<string, float>>(10);
                // Read All Lines from file
                string[] text = File.ReadAllLines(filename);
                // Cycle through all the lines
                for (int i = 1; i < text.Length; i++)
                {
                    // Separete lines according to accepted format
                    string[] subStrings = text[i].Split(',');

                    // If format is incorret or the second subString cannot be
                    // converted to float
                    if (subStrings.Length != 2 || !Single.TryParse(subStrings[1],
                        out float n))
                    {
                        // Send Error message
                        Console.WriteLine("The format of the file " +
                            "'HighScores.txt' is not correct.");
                        // Close program
                        Environment.Exit(0);
                    }

                    // Save name from the first subString
                    string name = subStrings[0];
                    // Save score from the second subString
                    float score = Convert.ToInt32(subStrings[1]);

                    // Add highscore to list
                    highscores.Add(new Tuple<string, float>(name, score));
                }
            }
        }

        // Method to Add a new Highscore
        public void AddScore(string name, float score)
        {
            // Create and instantiate a new object to hold the new highscore
            Tuple<string, float> newScore = new Tuple<string, float>(name, score);

            // Add highscore to list
            highscores.Add(newScore);

            // Sort the elements of the list in a descending order
            for (int i = 0; i <= highscores.Count - 1; i++)
            {
                for (int j = 0; j < highscores.Count - 1; j++)
                {
                    if (highscores[j].Item2 < highscores[i].Item2)
                    {
                        Tuple<string, float> temp = highscores[i];
                        highscores[i] = highscores[j];
                        highscores[j] = temp;
                    }
                }
            }

            // If list has more than 10 elements
            if (highscores.Count > 10)
            {
                // Remove last item on list
                highscores.RemoveAt(highscores.Count - 1);
            }
        }

        // Method to save highscores to file
        public void Save()
        {
            // Create variable to hold all text from list
            string text = "Name,Score\n";
            // For each element of the list
            foreach (Tuple<string, float> highscore in highscores)
            {
                // Add text with Name and score
                text += $"{highscore.Item1},{highscore.Item2}\n";
            }

            // Write all the highscores on the specified file
            File.WriteAllText("HighScores.txt", text);
        }

        // Overriding method ToString()
        public override string ToString()
        {
            // Create variable to hold all text from list
            string text = "Name          |Score\n";
            text += "-------------------------\n";
            // For each element of the list
            foreach (Tuple<string, float> highscore in highscores)
            {
                // Add text with Name and score in a table format
                text += $"{highscore.Item1,-14}|{highscore.Item2,-14}\n";
            }

            // Return string with formated table
            return text;
        }

        // Method that returns all highscores from list
        public IEnumerable<Tuple<string, float>> GetScores()
        {
            // Foreach highscore in list
            foreach (Tuple<string, float> highscore in highscores)
            {
                // Return the current highscore
                yield return highscore;
            }
        }
    }
}
