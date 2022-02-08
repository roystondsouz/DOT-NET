using System;
namespace Exercises
{
    class RegisterNum
    {
        int regNo;
        static int startNum;
        static RegisterNum()
        {
            startNum = 20210000;
        }
        RegisterNum()
        {
            regNo = ++startNum;
        }
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                RegisterNum Student = new RegisterNum();
                Console.WriteLine("Student {0} : {1}", i + 1, Student.regNo);
            }
        }
    }
}