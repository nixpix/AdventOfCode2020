using System;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@".\input.txt");

            List<String> input = new List<String>();

            while ((line = file.ReadLine()) != null)
            {
                input.Add(line);
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            int validPasswordCount = 0;

            foreach (String inputLine in input) {
                int separator = inputLine.IndexOf(":");
                char letter = char.Parse(inputLine.Substring(separator - 1, 1));
                String range = inputLine.Substring(0, separator - 2);
                String password = inputLine.Substring(separator + 2);

                int firstPosition, secondPosition;
                int separator2 = range.IndexOf("-");
                firstPosition = int.Parse(range.Substring(0, separator2)) - 1;
                secondPosition = int.Parse(range.Substring(separator2+1)) - 1;

                char[] passwordCharArray = password.ToCharArray();
                if (password[firstPosition] == letter ^ password[secondPosition] == letter)
                {
                    validPasswordCount++;
                    Console.WriteLine("letter: " + letter);
                    Console.WriteLine("min: " + firstPosition);
                    Console.WriteLine("max: " + secondPosition);
                    Console.WriteLine("password: " + password);
                    Console.WriteLine("----------------------------------");
                }

            }
            Console.WriteLine("validPasswordCount: " + validPasswordCount);

            
            
        }
    }
}
