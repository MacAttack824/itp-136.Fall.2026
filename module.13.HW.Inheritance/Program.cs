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

            studentList.Add(new Student(1001, "Harry Potter", "4 Privet Drive", "Defense", "Lupin"));
            studentList.Add(new Student(1002, "Ron Weasley", "The Burrow", "Potions", "Snape"));
            studentList.Add(new Student(1003, "Hermione Granger", "12 London Road", "Charms", "Flitwick"));
            studentList.Add(new Student(1004, "Neville Longbottom", "8 Willow Lane", "Herbology", "Sprout"));
            studentList.Add(new Student(1005, "Draco Malfoy", "Malfoy Manor", "Alchemy", "Snape"));

            teacherList.Add(new Teacher(2001, "Remus Lupin", "12 Forest Lane", 72500.00m, 8));
            teacherList.Add(new Teacher(2002, "Severus Snape", "Spinner's End", 85000.50m, 15));
            teacherList.Add(new Teacher(2003, "Filius Flitwick", "24 Castle Road", 78500.75m, 22));
            teacherList.Add(new Teacher(2004, "Pomona Sprout", "16 Garden Lane", 69000.25m, 19));
            teacherList.Add(new Teacher(2005, "Albus Dumbledore", "Hogwarts Castle", 125000.00m, 145));

            // A.Welcome statement to your program
            WelcomeMessage();

            while (true)
            {
                WriteLine("\nWhat would you like to do today?\n\n1-Add Student, 2-Add Teacher, 3-Display Students, 4-Display Teachers, 5-Exit");
                string userChoiceString = (ReadLine());
                
                bool success = int.TryParse(userChoiceString, out int userChoice);

                if (success)
                {
                    if (userChoice == 1)
                    {
                        // B.Ask for the number students user wants to enter.Add each student
                        // entered by the user to a student list.
                        PopulateStudent(studentList);
                    }

                    else if (userChoice == 2)
                    {
                        // C.Ask for the number of teachers the user wants to enter.Add each teacher
                        // entered by user to the teacher list.
                        PopulateTeacher(teacherList);
                    }

                    else if (userChoice == 3)
                    {
                        // D.Print out the students with headers.
                        DisplayStudent(studentList);
                    }

                    else if (userChoice == 4)
                    {
                        // E.Print out the teachers with headers.
                        DisplayTeacher(teacherList);
                    }
                    else if (userChoice == 5)
                    {
                        // Exit Program
                        break;
                    }
                    else
                    {
                        WriteLine("Invalid selection. Please enter 1-5.");
                    }
                }
                else
                {
                    WriteLine("Invalid NUMBER.");
                }
            }
        }


        // Methods
        static void WelcomeMessage()
        {
            WriteLine("Welcome to Mac's Magician Ministry");   //Think 'Hogwarts
        }

        static void PopulateStudent(List<Student> studentList)
        {
            WriteLine("How many students do you wish to enter: "); // get user data for amount of students
            try
            {
                int studentCount = ValidateInt(); // public Student( int idNum, string fullName, string address, string major, string advisor) : base(idNum, fullName, address) 

                for (int x = 0; x < studentCount; x++)
                {
                    WriteLine($"Enter student {x+1} ID Number: ");
                    int idNum = ValidateInt();

                    WriteLine($"Enter student {x + 1} Full Name: ");
                    string fullName = ReadLine();

                    WriteLine($"Enter student {x + 1} Address: ");
                    string address = ReadLine();

                    WriteLine($"Enter student {x + 1} Major: ");
                    string major = ReadLine();

                    WriteLine($"Enter student {x + 1} Advisor: ");
                    string advisor = ReadLine();

                    Student s = new Student(idNum, fullName, address, major, advisor);
                    studentList.Add(s);
                }
            }
            catch (FormatException e)
            {
                WriteLine("Please enter a valid count:" + "\n" + e);
            }

        }


        static void PopulateTeacher(List<Teacher> teacherList)
        {
            WriteLine("How many teachers do you wish to enter: ");   // get user data for amount of teachers

            try
            {
                int teacherCount = ValidateInt(); //public Teacher(int idNum, string fullName, string address, decimal salary, int yearsOfService) : base(idNum, fullName, address)

                for (int y = 0; y < teacherCount; y++)
                {
                    WriteLine($"Enter teacher {y + 1} ID Number: ");
                    int idNum = ValidateInt();

                    WriteLine($"Enter teacher {y + 1} Full Name: ");
                    string fullName = ReadLine();

                    WriteLine($"Enter teacher {y + 1} Address: ");
                    string address = ReadLine();

                    WriteLine($"Enter teacher {y + 1} Salary: ");
                    decimal salary = ValidateDec();

                    WriteLine($"Enter teacher {y + 1} Years of Service: ");
                    int yearsOfService = ValidateInt();

                    Teacher t = new Teacher(idNum, fullName, address, salary, yearsOfService);
                    teacherList.Add(t);
                }
            }
            catch (Exception e)
            {
                WriteLine("Please enter a valid count: " + "\n" + e);
            }
        }


        static void DisplayStudent(List<Student> studentList)
        {
            WriteLine("\n{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Student ID","Student Name","Student Address", "Student Major", "Student Advisor");
            foreach (Student s in studentList)
            {
                WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", s.IDNum, s.FullName, s.Address, s.Major, s.Advisor);
            }
        }


        static void DisplayTeacher(List<Teacher> teacherList)
        {
            WriteLine("\n{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Teacher ID", "Teacher Name", "Teacher Address", "Teacher Salary", "Years of Service");
            foreach (Teacher t in teacherList)
            {
                WriteLine("{0,-15}{1,-20}{2,-30}{3,14:C2}{4,17}", t.IDNum, t.FullName, t.Address, t.Salary, t.YearsOfService);
            }
        }


        static int ValidateInt()
        {
            int validInt;
            string i = ReadLine();
            bool valid = int.TryParse(i, out validInt);

            while (!valid)
            {
                WriteLine("Please enter valid integer");

                i = ReadLine();
                valid = int.TryParse(i, out validInt);
            }
            return validInt;
        }
        static decimal ValidateDec()
        {
            decimal validDec;
            string d = ReadLine();
            bool valid = decimal.TryParse(d, out validDec);

            while (!valid)
            {
                WriteLine("Please enter valid decimal");

                d = ReadLine();
                valid = decimal.TryParse(d, out validDec);
            }
            return validDec;
        }
    }
}
