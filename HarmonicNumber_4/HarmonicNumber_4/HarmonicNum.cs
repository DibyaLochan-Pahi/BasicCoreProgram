using System;

namespace HarmonicNumber_4
{
    internal class HarmonicNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value of N ");
            double input=Double.Parse(Console.ReadLine());
            double num = 0;
            double num2 = 0;
            Harmonic(input,num,num2);
        }

        private static void Harmonic(double input, double num , double num2 )
        {
            
            if (input != 0)
            {
                for (double i = 1; i < input; i++)
                {
                    num = 1 / i;
                    Console.Write("(1/" + i+ ")+");
                    num2 = num + num2;                    
                }                
            }
            else 
            {
                Console.WriteLine("Enter Value can not be Zero");
            }
            Console.WriteLine(" = Final OutPut is " + num2);
        }
    }
}
