using System;

namespace P019
{
    class Program
    {
        static void Main(string[] args)
        {
            int sundays = 0;
            int nextDay = 0;
            int startDay = GetStartOfNextMonth(1900, 1, 0);
            for(int i = 2; i <= 12; i++)
            {
                startDay = GetStartOfNextMonth(1900, i, startDay);
            }
            for (int y = 1901; y <= 2000; y++)
            {
                for (int m = 1; m <= 12; m++)
                {
                    nextDay = GetStartOfNextMonth(y, m, startDay);
                    if (nextDay == 6) { sundays++; Console.WriteLine(y + " " + m); }
                    startDay = nextDay;
                }
            }
            Console.WriteLine(sundays);
        }
        static int GetStartOfNextMonth(int year, int i, int initialDay)
        {
            int nextStartID;
            int days = 0;
                if ((i==9) || (i==4) || (i==6) || (i==11))
                { // september, april, june, november
                    days += 30;
                }
                else if (i==2){ // february
                    if ((year % 4 == 0) && (year % 400 == 0) && (year%100 == 0))
                    {
                        days += 29;
                    }
                    else if ((year % 4 == 0) && (year % 400 != 0) && (year%100 == 0))
                    {
                        days += 28;
                    }
                    else if (year % 4 == 0)
                    {
                        days += 29;
                    }
                    else if (year % 4 != 0)
                    {
                        days += 28;
                    }
                }
                else
                {// all other months
                    days += 31;
                }
            days = days - (7 - initialDay);
            while (days > 7)
            {
                days -= 7;
            }
            nextStartID = days;
            return nextStartID;
        }
    }
}