using System;
using System.Threading;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int head =0;
            int tail =0;
            Console.WriteLine("Enter How Many Time Want to Flip");
            int count = Int32.Parse(Console.ReadLine());
            Random random = new Random();
            Coinflip(count,random,head,tail);            
        }
        public static void Coinflip(int count,Random random,int head,int tail)
        {           
            for (int i = 0; i < count; i++)
            {
                int flip = random.Next(0, 2);
                if (flip == 1)
                {
                    Console.WriteLine("Head");
                    head++;
                }
                else
                {
                    Console.WriteLine("Tail");
                    tail++;
                }
            }
            double headper = (head * 100) / count;
            Console.WriteLine("Head Percentage: " + headper + "%");
            double tailper = (tail * 100) / count;
            Console.WriteLine("Tail Percentage" + tailper+ "%");           
        }      
    }
}
