using System;

namespace SwapTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter First Number : ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
            
        }
    }
}
