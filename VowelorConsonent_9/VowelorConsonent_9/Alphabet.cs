using System;

namespace VowelorConsonent_9
{
    internal class Alphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Alphabet");
            char input= char.Parse(Console.ReadLine());
            checkAlphabet(input);
            
        }

        private static void checkAlphabet(char input)
        {
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u'||
                input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
            {
                Console.WriteLine("Alphabate is Vowel");

            }
            else
            {
                Console.WriteLine("Alphabate is Consonent");
            }
        }
    }
}
