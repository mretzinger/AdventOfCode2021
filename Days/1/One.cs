using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days
{
    public class One
    {
        public void Run()
        {
            ParsePartTwo();
        }


        public void ParsePartOne()
        {
            StreamReader file = new StreamReader("\\Data.txt");
            string line;
            List<int> depthMeasurements = new List<int>();
            int index = 0;
            int finalCount = 0;//1521

            while ((line = file.ReadLine()) != null)
            {
                depthMeasurements.Add(int.Parse(line));
            }

            foreach (int item in depthMeasurements)
            {
                index += 1;
                if (index < depthMeasurements.Count() && item < depthMeasurements[index])
                {
                    finalCount++;
                }

            }

            Console.WriteLine(finalCount);
        }

        public void ParsePartTwo()
        {
            StreamReader file = new StreamReader("\\Data.txt");
            string line;
            List<int> depthMeasurements = new List<int>();
            int index = 0;
            int finalCount = 0;

            while ((line = file.ReadLine()) != null)
            {
                depthMeasurements.Add(int.Parse(line));
            }

        }
    }
}
