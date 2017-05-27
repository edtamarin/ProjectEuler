using System;
using System.Numerics;

namespace P016
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number;
            int sum = 0;
            number = (BigInteger)Math.Pow(2, 1000);
            string numStr = number.ToString();
            for(int i = 0; i < numStr.Length; i++)
            {
                sum += int.Parse(numStr[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}