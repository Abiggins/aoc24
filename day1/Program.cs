using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

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
int probabilityScore = 0;
for (int i = 0; i < leftList.Count; i++)
{
    sum += Math.Abs(leftList[i] - rightList[i]);
    int count = 0;
    int value = 0;

    foreach (int rightNum in rightList)
    {
        if (leftList[i] == rightNum)
        {
            count++;
        }
    }
    value = leftList[i] * count;
    probabilityScore += value;
}

Console.WriteLine(sum);
Console.WriteLine(probabilityScore);

