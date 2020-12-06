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


            int invalidPasswordCount = 0;

            foreach (String inputLine in input) {
                int separator = inputLine.IndexOf(":");
                char letter = char.Parse(inputLine.Substring(separator - 1, 1));
                String range = inputLine.Substring(0, separator - 2);
                String password = inputLine.Substring(separator + 2);

                int min, max;
                int separator2 = range.IndexOf("-");
                min = int.Parse(range.Substring(0, separator2));
                max = int.Parse(range.Substring(separator2+1));

                int count = 0;
                char[] passwordCharArray = password.ToCharArray();
                for (int i = 0; i < password.Length; i++)
                {
                    if (passwordCharArray[i] == letter)
                        count++;
                }

                if (!(count <= max && count >= min))
                {
                    invalidPasswordCount++;
                    Console.WriteLine("letter: " + letter);
                    Console.WriteLine("min: " + min);
                    Console.WriteLine("max: " + max);
                    Console.WriteLine("password: " + password);
                    Console.WriteLine("count: " + count);
                    Console.WriteLine("----------------------------------");
                }

            }
            Console.WriteLine(invalidPasswordCount);

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.WriteLine("Result: " + (counter - invalidPasswordCount));
            
        }
    }
}
