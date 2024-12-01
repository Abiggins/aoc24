using System;
using System.Collections.Generic;
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

            string line;

            while((line = sr.ReadLine()) != null)
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
        }
    }
}