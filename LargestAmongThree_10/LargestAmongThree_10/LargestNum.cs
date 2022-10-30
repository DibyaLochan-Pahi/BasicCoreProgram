using System;

namespace LargestAmongThree_10
{
    internal class LargestNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num3 = Int32.Parse(Console.ReadLine());
            Largestnum(num1, num2, num3);
        }

        private static void Largestnum(int num1, int num2, int num3)
        {
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine(num1 + " is Largest");
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine(num2 + " is Largest");
            }
            else
            {
                Console.WriteLine(num3 + " is Largest");
            }

        }
    }
}
