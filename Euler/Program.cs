using System;
using System.Numerics;

namespace P013
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            BigInteger sum = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(new System.IO.FileStream(@"D:\Egor\Documents\GitHub\ProjectEuler\Euler\res\R013.txt",
                System.IO.FileMode.Open, System.IO.FileAccess.Read));
            while ((line = file.ReadLine()) != null)
            {
                line = line.Substring(0, 12);
                BigInteger digits = BigInteger.Parse(line);
                sum += digits;
            }
            string result = sum.ToString();
            result = result.Substring(0, 10);
            Console.WriteLine(result);
        }
    }
}