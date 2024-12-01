using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace day1
{
    class ListDistances
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();
            List<int> differences = new List<int>();
            List<int> probabilityList = new List<int>();

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                leftList.Add(int.Parse(line.Split("   ")[0]));
                rightList.Add(int.Parse(line.Split("   ")[1]));
            }

            leftList.Sort();
            rightList.Sort();

            int sum = 0;
            for (int i = 0; i < leftList.Count; i++)
            {
                sum += Math.Abs(leftList[i] - rightList[i]);
            }

            Console.WriteLine(sum);

            int probabilityScore = 0;
            foreach (int leftNum in leftList)
            {
                int count = 0;
                int value = 0;
                foreach (int rightNum in rightList)
                {
                    if (leftNum == rightNum)
                    {
                        count++;
                    }
                }
                value = leftNum * count;
                probabilityScore += value;
            }

            Console.WriteLine(probabilityScore);

        }
    }
}