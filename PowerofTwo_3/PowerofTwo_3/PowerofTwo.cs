using System;

namespace PowerofTwo_3
{
    internal class PowerofTwo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Input Power of 2 table : ");
            int input=Int32.Parse(Console.ReadLine());
            int num = 0;
            int num2 = 1;
            PowerTable(num, input,num2);
        }

        private static void PowerTable(int num, int input,int num2)
        {
            if (input < 31)
            {
                for (int i = 1; i <= input; i++)
                {

                    num = num2 * 2;
                    Console.WriteLine("2 To the Power "+ i + " Value is " + num);
                    num2 = num;

                }
            }
            else 
            {
                Console.WriteLine("Enter below 31");

            }


        }
    }
}
