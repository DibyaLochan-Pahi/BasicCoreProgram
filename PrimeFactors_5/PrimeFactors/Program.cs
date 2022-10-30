using System;

namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = Int32.Parse(Console.ReadLine());
            PrimeFactors(input);
                      
        }

        private static void PrimeFactors(int input)
        {
            while (input % 2 == 0)
            {
                Console.Write(2 + " ");
                input = input / 2;
            }
            for (int i = 3; i <= Math.Sqrt(input); i = i + 2)
            {
                while (input % i == 0)
                {
                    Console.Write(i + " ");
                    input = input / i;
                }
            }
            if (input > 2)
                Console.WriteLine(input);
        }
    }
}
