using System;

namespace CheackLeapYearorNot_2
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Year");
            int year=Int32.Parse(Console.ReadLine());
            CheckYear(year);
        }

        private static void CheckYear(int year)
        {
            //To ensure it is a 4 Digit Number
            if(year > 1000 && year<10000)
            {
                //To Check year is a multiple of 4
                //and not multiple by 100
                //or year is multiple by 400
                if (((year % 4==0) && (year %100!=0 ))|| (year %400==0))
                {
                    Console.WriteLine("Year is a Leap Year");
                }
                else
                {
                    Console.WriteLine("Year is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Year");
            }
        }
    }
}
