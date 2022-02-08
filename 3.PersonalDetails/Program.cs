using System;
namespace Exercises
{
    class PersonalDetails
    {
        string name;
        int age;
        string gender;
        public PersonalDetails(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n-------- PERSONAL DETAILS --------\n");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
        }
    }
    class CourseDetails : PersonalDetails
    {
        int regNo;
        string course;
        int semester;
        public CourseDetails(string name, int age, string gender, int regNo, string course, int semester) : base(name, age, gender)
        {
            this.regNo = regNo;
            this.course = course;
            this.semester = semester;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\n-------- COURSE DETAILS --------\n");
            Console.WriteLine("Register Number : " + regNo);
            Console.WriteLine("Course : " + course);
            Console.WriteLine("Semester : " + semester);
        }
    }
    class MarksDetails : CourseDetails
    {
        int[] marks = new int[5];
        int total;
        float average;
        string grade;
        int flagFail;
        public MarksDetails(string name, int age, string gender, int regNo, string course, int semester, int[] marks) : base(name, age, gender, regNo, course, semester)
        {
            total = 0;
            for (int i = 0; i < 5; i++)
            {
                this.marks[i] = marks[i];
                total += marks[i];
                if (marks[i] < 35)
                {
                    flagFail = 1;
                }
            }
            Calculate();
        }
        private void Calculate()
        {
            average = total / 5;
            if (flagFail == 1 || average < 40)
                grade = "Fail";
            else if (average >= 70)
                grade = "Distinction";
            else if (average >= 60)
                grade = "First Class";
            else if (average >= 50)
                grade = "Second Class";
            else
                grade = "Pass Class";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\n-------- MARKS DETAILS --------\n");
            Console.Write("Marks in 5 subjects: ");
            for (int i = 0; i < 5; i++)
                Console.Write(marks[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Total : " + total);
            Console.WriteLine("Average : " + average);
            Console.WriteLine("Grade : " + grade);
        }
    }
    class MultiLevel
    {
        public static void Main(string[] args)
        {
            MarksDetails Student1 = new MarksDetails("Allen", 21, "Male", 20190001, "MSc", 5, new int[] { 77, 80, 98, 95, 90 });
            Student1.Display();
        }
    }
}