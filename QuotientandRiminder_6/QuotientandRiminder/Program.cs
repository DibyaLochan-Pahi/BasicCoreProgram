using System;

namespace QuotientandRiminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dividend");
            int num1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int num2=Int32.Parse(Console.ReadLine());
            int quotient= getQuotient(num1, num2);
            int reminder=getRiminder(num1, num2);
            Console.WriteLine("The Quotient is = "+quotient);
            Console.WriteLine("The reminder is = "+ reminder);
        }

        private static int getRiminder(int num1, int num2)
        {
            return num1 % num2;
        }

        private static int getQuotient(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
