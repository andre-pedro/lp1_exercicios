using System;
using System.Collections.Generic;
using System.IO;

namespace LP1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to hold filename from argument 1
            string filename = "";
            // Variable to hold user input
            string userInput = "";
            // List to hold all text to write to file
            List<string> allText = new List<string>();

            // If a file is given as argument
            if (args.Length <= 1)
            {
                // Filename is first argument
                filename = args[0];

                // Do cycle while string userInput is not empty
                do
                {
                    // Ask for user input
                    Console.Write("Write Something: ");
                    userInput = Console.ReadLine();
                    // Convert userInput to Uppercase
                    userInput = userInput.ToUpper();
                    // Add text to list 
                    allText.Add(userInput + "\n");

                    // Write text on file
                    File.WriteAllLines(filename, allText);

                } while (userInput != "");
            }
            // If there is no file as argument
            else
            {
                // Ask for a file
                Console.WriteLine("Please enter a filename.");
            }
        }
    }
}
