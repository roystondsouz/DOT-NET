using System;
namespace Exercises
{
    class Register_number
    {
        int regno;
        static int startnum;
        static Register_number()
        {
            startnum = 20210000;
        }
        Register_number()
        {
            regno = ++startnum;
        }
        public static void Main(string[] args)

        {
            for (int i = 0; i < 100; i++)
            {

                Register_number student = new Register_number();
                Console.WriteLine("students {0} : {1}",i+1,student.regno);
            }

        }
    }
}



