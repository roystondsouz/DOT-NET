
using System;
namespace Exercises
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.displayAge();
            }
            catch (AgeIsNegativeException e)
            {
                Console.WriteLine("AgeIsNegativeException: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Execution of Finally block is done.");
            }
        }
    }
}
public class AgeIsNegativeException : Exception
{
    public AgeIsNegativeException(string message) : base(message)
    {
    }
}
public class Age
{
    int age = -5;
    public void displayAge()
    {
        if (age < 0)
        {
            throw (new AgeIsNegativeException("Age cannot be negative"));
        }
        else
        {
            Console.WriteLine("Age is: {0}", age);
        }
    }
}
