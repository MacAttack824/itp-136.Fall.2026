namespace module._13.HW.Inheritance
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 13
            // 4. Main
            // A.Welcome statement to your program
            WelcomeMessage();

            // B.Ask for the number students user wants to enter.Add each student
            // entered by the user to a student list.
            int studentCount = StudentCounter();

            // C.Ask for the number of teachers the user wants to enter.Add each teacher
            // entered by user to the teacher list.
            int teacherCount = TeacherCounter();

            // D.Print out the students with headers.
            DisplayStudent();

            // E.Print out the teachers with headers.
            DisplayTeacher();

            ReadKey();
        }


        // Methods
        static void WelcomeMessage()
        {
            WriteLine("Welcome to Mac's Magician Ministry");   //Think 'Hogwarts
        }

        static int StudentCounter()
        {
            WriteLine("XXXX");   //Think 'Hogwarts'
            int studentCount = Convert.ToInt32(ReadLine());
            return studentCount;
        }

        static int TeacherCounter()
        {
            WriteLine("XXXX");   //Think 'Hogwarts'
            int teacherCount = Convert.ToInt32(ReadLine());
            return teacherCount;


        }
        static void DisplayStudent()
        {
            WriteLine("");
        }
        static void DisplayTeacher()
        {
            WriteLine("");
        }
    }
}
