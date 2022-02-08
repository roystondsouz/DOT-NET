using System;
namespace Exercises
{
    class FrequencyIS
    {
        static void Main(string[] args)
        {
            int count = 0;
            string inputString;
            Console.WriteLine("\n----------- Frequency of word 'is' ----------");
            Console.Write("\n Enter the input string: ");
            inputString = Console.ReadLine();
            char[] separator = { ',', ' ', '.', '!', '\n' };
            string testString = inputString.ToLower();
            String[] outcomes = testString.Split(separator);
            foreach (String s in outcomes)
            {
                Console.WriteLine(s);
                if (s == "is")
                    count++;
            }
            Console.WriteLine("\n Number of 'is' in '" + inputString + "' is: " + count);
        }
    }
}
