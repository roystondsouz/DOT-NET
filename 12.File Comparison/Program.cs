using System;
using System.IO;
namespace Exercises
{
    class FileRead
    {
        public static void Main()
        {
            string file1;
            string file2;

            Console.Write("Enter the first file path:");
            file1 = Console.ReadLine();
            Console.Write("Enter the second file path:");
            file2 = Console.ReadLine();
            if (!File.Exists(file1))
            {
                Console.WriteLine("First file does not exist!");
            }
            else if (!File.Exists(file2))
            {
                Console.WriteLine("Second file does not exist!");
            }
            else if (File.ReadAllText(file1) == File.ReadAllText(file2))
            {
                Console.WriteLine("Both files contain the same content");
            }
            else
            {
                Console.WriteLine("Contents of files are not same");
            }
        }
    }
}
