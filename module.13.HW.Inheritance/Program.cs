namespace module._13.HW.Inheritance
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 13
            // 4. Main
            List<Student> studentList = new List<Student>(); // creates a new instance of a LIST of CLASS of STUDENTS
            List<Teacher> teacherList = new List<Teacher>(); // creates a new instance of a LIST of CLASS of TEACHERS

            // A.Welcome statement to your program
            WelcomeMessage();

            // B.Ask for the number students user wants to enter.Add each student
            // entered by the user to a student list.
            PopulateStudent(studentList);

            // C.Ask for the number of teachers the user wants to enter.Add each teacher
            // entered by user to the teacher list.

            PopulateTeacher(teacherList);

            // D.Print out the students with headers.
            DisplayStudent(studentList);

            // E.Print out the teachers with headers.
            DisplayTeacher(teacherList);

            ReadKey();
        }


        // Methods
        static void WelcomeMessage()
        {
            WriteLine("Welcome to Mac's Magician Ministry");   //Think 'Hogwarts
        }

        static void PopulateStudent(List<Student> studentList)
        {
            WriteLine("How many students do you wish to enter: "); // get user data for amount of students
            int studentCount = Convert.ToInt32(ReadLine()); // public Student( int idNum, string fullName, string address, string major, string advisor) : base(idNum, fullName, address) 
            
            for (int x = 0; x < studentCount; x++)
            {
                WriteLine("Enter student's ID Number: ");
                int idNum = Convert.ToInt32(ReadLine());

                WriteLine("Enter student's Full Name: ");
                string fullName = ReadLine();

                WriteLine("Enter student's Address: ");
                string address = ReadLine();

                WriteLine("Enter student's Major: ");
                string major = ReadLine();

                WriteLine("Enter student's Advisor: ");
                string advisor = ReadLine();

                Student s = new Student(idNum, fullName, address, major, advisor);
                studentList.Add(s);
            }
        }

        static void PopulateTeacher(List<Teacher> teacherList)
        {
            WriteLine("How many teachers do you wish to enter: ");   // get user data for amount of teachers
            int teacherCount = Convert.ToInt32(ReadLine()); //public Teacher(int idNum, string fullName, string address, decimal salary, int yearsOfService) : base(idNum, fullName, address)

            for (int y = 0; y < teacherCount; y++)
            {
                WriteLine("Enter teacher's ID Number: ");
                int idNum = Convert.ToInt32(ReadLine());

                WriteLine("Enter teacher's Full Name: ");
                string fullName = ReadLine();

                WriteLine("Enter teacher's Address: ");
                string address = ReadLine();

                WriteLine("Enter teacher's Salary: ");
                decimal salary = Convert.ToDecimal(ReadLine());

                WriteLine("Enter teacher's Years of Service: ");
                int yearsOfService = Convert.ToInt32(ReadLine());

                Teacher t = new Teacher(idNum, fullName, address, salary, yearsOfService);
                teacherList.Add(t);
            }




        }
        static void DisplayStudent(List<Student> studentList)
        {
            WriteLine("{0,20}{1,20}{2,30}{3,15}{4,20}", "Student ID","Student Name","Student Address", "Student Major", "Student Advisor");
            foreach (Student s in studentList)
            {
                WriteLine("{0,20}{1,20}{2,30}{3,15}{4,20}", s.IDNum, s.FullName, s.Address, s.Major, s.Advisor);
            }
        }
        static void DisplayTeacher(List<Teacher> teacherList)
        {
            WriteLine("{0,20}{1,20}{2,30}{3,15}{4,20}", "Teacher ID", "Teacher Name", "Teacher Address", "Teacher Salary", "Years of Service");
            foreach (Teacher t in teacherList)
            {
                WriteLine("{0,20}{1,20}{2,30}{3,15:C2}{4,20}", t.IDNum, t.FullName, t.Address, t.Salary, t.YearsOfService);
            }
        }
    }
}
