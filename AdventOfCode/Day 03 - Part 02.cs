using System;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> input = readInputFile();
            int firstSlopeTreeCount = findTreesForSlope(1, 1, input);
            int secondSlopeTreeCount = findTreesForSlope(3, 1, input);
            int thirdSlopeTreeCount = findTreesForSlope(5, 1, input);
            int fourthSlopeTreeCount = findTreesForSlope(7, 1, input);
            int fifthSlopeTreeCount = findTreesForSlope(1, 2, input);

            Console.WriteLine("Multiplied count of trees on all slopes: " + firstSlopeTreeCount * secondSlopeTreeCount * thirdSlopeTreeCount * fourthSlopeTreeCount * fifthSlopeTreeCount);
        }

        static List<String> readInputFile()
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
            return input;
        }

        static int findTreesForSlope(int x, int y, List<String> input)
        {
            int posY = 0;
            int treeCounter = 0;

            for (int i = 0, j = 0; j < input.Count; i = i + x, j = j + y)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    String inputLine = input[j];
                    char[] line = inputLine.ToCharArray();
                    if (i >= inputLine.Length)
                    {
                        i -= inputLine.Length;
                    }

                    if (line[i] == '#')
                    {
                        treeCounter++;
                    }
                }
            }
            Console.WriteLine("Counted trees on slope x = " + x + ", y = " + y +" : "+ treeCounter);
            return treeCounter;
        }
    }
}
