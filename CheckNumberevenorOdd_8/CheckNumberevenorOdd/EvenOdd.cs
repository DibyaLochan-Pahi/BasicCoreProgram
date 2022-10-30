using System;

namespace CheckNumberevenorOdd
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num=Int32.Parse(Console.ReadLine());
            OddEven(num);
            
        }

        private static void OddEven(int num)
        {
            if(num%2 != 0)
            {
                Console.WriteLine("Number is Odd");
            }
            else
            {
                Console.WriteLine("Number is Even");
            }
        }
    }
}
