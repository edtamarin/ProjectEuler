using System;
using System.Collections;
using System.Collections.Generic;

namespace P017
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            //int lineNum = 1;
            List<string> triangle = new List<string>();
            List<int> sum = new List<int>();
            System.IO.StreamReader file = new System.IO.StreamReader(new System.IO.FileStream(@"D:\Egor\Documents\GitHub\ProjectEuler\Euler\P017\res\R017.txt", 
                System.IO.FileMode.Open, System.IO.FileAccess.Read));
            while((line = file.ReadLine()) != null)
            {
                triangle.Add(line);
            }
            List<int> thisLine = new List<int>();
            thisLine.Add(75);
            for (int i = 0; i < triangle.Count-1; i++)
            {
                string[] nextLine = triangle[i + 1].Split(' ');
                for(int j = 0; j < nextLine.Length-1; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        //Console.WriteLine(i + " " + (j + k) + j + k);
                        int temp = thisLine[j] + int.Parse(nextLine[j + k]);
                        //Console.WriteLine(nextLine[j + k] + " " + thisLine[i] + " " +temp);
                        sum.Add(temp);
                    }
                }
                thisLine = new List<int>(sum);
                for(int a = 0; a < thisLine.Count; a++)
                {
                    Console.Write(thisLine[a] + " ");
                }
                Console.WriteLine();
                sum.Clear();
            }
            thisLine.Sort();
            Console.WriteLine(thisLine[thisLine.Count-1]);
        }
    }
}