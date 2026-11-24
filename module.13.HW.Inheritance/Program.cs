namespace module._13.HW.Inheritance
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 13
            // 4. Main
            List<Student> studentList = new List<Student>(); // creates a new instance of a LIST of CLASS of STUDENTS; empty list of Student
            List<Teacher> teacherList = new List<Teacher>(); // creates a new instance of a LIST of CLASS of TEACHERS; empty list of Teacher

            // A.Welcome statement to your program
            WelcomeMessage();

            while (true) // loop keeps program operating to add and view students, teachers, and add as necessary
            {
                WriteLine("\nWhat would you like to do today?\n\n1-Add Student, 2-Add Teacher, 3-Display Students, 4-Display Teachers, 5-Exit");
                int userChoice = ValidateInt();  // take user input to chose from menu
 
                if (userChoice == 1)
                {
                    // B.Ask for the number students user wants to enter. Add each student
                    // entered by the user to a student list.
                    PopulateStudent(studentList);
                }

                else if (userChoice == 2)
                {
                    // C.Ask for the number of teachers the user wants to enter. Add each teacher
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
                    // if any number other than 1-5 loops back in menu
                    WriteLine("Invalid selection. Please enter 1-5.");
                }
            }
        }


        // Methods
        static void WelcomeMessage()
        {
            WriteLine("Welcome to Mac's Magician Ministry \n Located at \n Mac's Magician Ministry \n 404 Wandering Wizard Way \n Broomstick Junction, VA 23231"); // Think 'Hogwarts'
            WriteLine("Contact us at \n Phone: 1-800-HEX-HELP \n Email: admissions@macsministry.example \n Headmaster: Professor Mac, Master of Magical Mischief"); // School information
        }

        static void PopulateStudent(List<Student> studentList) // method to add students to the list, use data type and variable name
        {
            WriteLine("How many students do you wish to enter: "); // get user data for amount of students

            int studentCount = ValidateInt(); // public Student( int idNum, string fullName, string address, string major, string advisor) : base(idNum, fullName, address) 

            for (int x = 0; x < studentCount; x++) // loop through each student to add to list
            {
                WriteLine($"Enter student {x+1} ID Number: ");  // enters student ID number
                int idNum = ValidateInt();

                WriteLine($"Enter student {x + 1} Full Name: "); // enters student full name
                string fullName = ReadLine();

                WriteLine($"Enter student {x + 1} Address: "); // enters student address
                string address = ReadLine();

                WriteLine($"Enter student {x + 1} Major: "); // enters student major
                string major = ReadLine();

                WriteLine($"Enter student {x + 1} Advisor: "); // enters student advisor
                string advisor = ReadLine();

                Student s = new Student(idNum, fullName, address, major, advisor); //calls class and variable 's' to create new Student object with constructors of base person and Student 
                studentList.Add(s);  // adds 's' to the student list
            }
        }


        static void PopulateTeacher(List<Teacher> teacherList) // method to add teachers. data type and variable
        {
            WriteLine("How many teachers do you wish to enter: ");   // get user data for amount of teachers

            int teacherCount = ValidateInt(); // public Teacher(int idNum, string fullName, string address, decimal salary, int yearsOfService) : base(idNum, fullName, address)

            for (int y = 0; y < teacherCount; y++) // loop though each teacher to add to list
            {
                WriteLine($"Enter teacher {y + 1} ID Number: "); // enters teacher ID number
                int idNum = ValidateInt();

                WriteLine($"Enter teacher {y + 1} Full Name: "); // enters teacher full name
                string fullName = ReadLine();

                WriteLine($"Enter teacher {y + 1} Address: "); // enters teacher address
                string address = ReadLine();

                WriteLine($"Enter teacher {y + 1} Salary: "); // enters teacher salary
                decimal salary = ValidateDec();

                WriteLine($"Enter teacher {y + 1} Years of Service: "); // enters teacher years of service
                int yearsOfService = ValidateInt();

                Teacher t = new Teacher(idNum, fullName, address, salary, yearsOfService); // variable 't' for teacher to identify new object Teacher
                teacherList.Add(t); // adds teacher to list with variable 't'
            }
        }


        static void DisplayStudent(List<Student> studentList)
        {
            WriteLine("\n{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Student ID","Student Name","Student Address", "Student Major", "Student Advisor"); // Header
            foreach (Student s in studentList) // foreach loops through each 's' of the students in the list 
            {
                WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", s.IDNum, s.FullName, s.Address, s.Major, s.Advisor); // use student properties to 'get'
            }
        }


        static void DisplayTeacher(List<Teacher> teacherList)
        {
            WriteLine("\n{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Teacher ID", "Teacher Name", "Teacher Address", "Teacher Salary", "Years of Service"); // Header
            foreach (Teacher t in teacherList) //foreach loops through each 't' of the teachers in the list
            { 
                WriteLine("{0,-15}{1,-20}{2,-30}{3,14:C2}{4,17}", t.IDNum, t.FullName, t.Address, t.Salary, t.YearsOfService); // use teacher properties, the 'get' of the class
            }
        }


        static int ValidateInt() // method to validate input from user
        {
            int validInt;  // declare int validInt variable
            string i = ReadLine(); // read user input as string
            bool valid = int.TryParse(i, out validInt); // declare bool to test if input can be changed to data type int. if passes valid == True

            while (!valid) // while valid data is false, loops until valid data is recieved
            {
                WriteLine("Please enter valid integer"); // reiterate the requested input
                i = ReadLine(); 
                valid = int.TryParse(i, out validInt);
            }
            return validInt;
        }
        static decimal ValidateDec() // method to validate input from user
        {
            decimal validDec; // declare decimal validDec variable
            string d = ReadLine(); // read user input as string
            bool valid = decimal.TryParse(d, out validDec); // declare bool to test if input can be changed to data type int. if passes valid == True

            while (!valid)// while valid data is false, loops until valid data is recieved
            {
                WriteLine("Please enter valid decimal"); // reiterate the requested input
                d = ReadLine();
                valid = decimal.TryParse(d, out validDec);
            }
            return validDec;
        }
    }
}
