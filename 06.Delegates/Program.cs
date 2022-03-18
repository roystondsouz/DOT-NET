using System;

namespace Delegates
{
    class Delegate
    {
        delegate string UppercaseDelegate(string input);
        static string UppercaseFirst(string input)
        {
            char[] buffer = input.ToCharArray();
        buffer[0]=char.ToUpper(buffer[0]);
            return new string(buffer);
        }
    static string UppercaseLast(string input)
    {
        char[] buffer = input.ToCharArray();
        buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]);
        return new string(buffer);
    }
    static string UppercaseAll(string input)
    {
        return input.ToUpper();
    }
    static void WriteOutput(string input, UppercaseDelegate del)
    {
        Console.WriteLine("Input.String:{0}", input);
        Console.WriteLine("output string:{0}", del(input));
    }
    static void Main()
    {
        WriteOutput("Roy", new UppercaseDelegate(UppercaseFirst));
        WriteOutput("Roy", new UppercaseDelegate(UppercaseLast));
        WriteOutput("Roy", new UppercaseDelegate(UppercaseAll));
        Console.ReadLine();
    }
}
}

