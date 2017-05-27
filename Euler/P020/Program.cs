using System;
using System.Numerics;

namespace P020
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            BigInteger num = Factorial(100);
            string numString = num.ToString();
            for (int i = 0; i < numString.Length; i++)
            {
                sum += Int16.Parse(numString[i].ToString());
            }
            Console.WriteLine(sum);
        }
        static BigInteger Factorial(int number)
        {
            if (number <= 1) return 1;
            return number * Factorial(number-1);
        }
    }
}