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
            int posY = 0;
            int treeCounter = 0;
            bool firstLine = true;
            foreach (String inputLine in input) {
                if (firstLine)
                {
                    firstLine = false;
                } else
                {
                    char[] line = inputLine.ToCharArray();
                    posY += 3;
                    //posX += 1;
                    if (posY >= inputLine.Length)
                    {
                        posY -= inputLine.Length;
                    }

                    if (line[posY] == '#')
                    {
                        treeCounter++;
                    }
                }              
            }
            Console.WriteLine("Counted trees: " + treeCounter);            
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
    }
}
