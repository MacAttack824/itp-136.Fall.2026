namespace module._12.CW
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1313, 5000.99, "Stephens", "David", "Programmer");

            WriteLine(emp1.EmployeeNumber + " " + emp1.FirstName + " " + emp1.LastName);


            int numEmp;

            WriteLine("How many employees would you like to enter? ");
            numEmp = Convert.ToInt32(ReadLine());

            Employee[] empArray = new Employee[numEmp];

            for (int x = 0; x < empArray.Length; x++)
            {
                populateEmployee(ref empArray[x]);
            }
            WriteLine("{0,15} {1,20} {2,20} {3,15} {4,20}", "Employee #", "First", "Last", "Salary", "Position");

            for (int y = 0; y < empArray.Length; y++)
            {
                WriteLine("{0,15} {1,20} {2,20} {3,15} {4,20}", empArray[y].EmployeeNumber, empArray[y].FirstName, empArray[y].LastName, empArray[y].Salary, empArray[y].Position);
            }

            WriteLine("Which Employee would you like to edit? ");
            for (int z = 0; z < empArray.Length; z++)
            {
                WriteLine("{0,15} {1,20} {2,20} {3,15} {4,20} {5,20}", z + 1, empArray[z].EmployeeNumber, empArray[z].FirstName, empArray[z].LastName, empArray[z].Salary, empArray[z].Position);
            }

            int selectedEmployee = Convert.ToInt32(ReadLine());

            modifyEmployee(ref empArray[selectedEmployee - 1]);

            WriteLine("{0,15} {1,20} {2,20} {3,15} {4,20}", "Employee #", "First", "Last", "Salary", "Position");

            for (int y = 0; y < empArray.Length; y++)
            {
                WriteLine("{0,15} {1,20} {2,20} {3,15} {4,20}", empArray[y].EmployeeNumber, empArray[y].FirstName, empArray[y].LastName, empArray[y].Salary, empArray[y].Position);
            }


            ReadKey();


        }
        static void populateEmployee(ref Employee e)
        {
            WriteLine("Enter employee number: ");
            int empNum = Convert.ToInt32(ReadLine());

            WriteLine("Enter employee salary: ");
            double s = Convert.ToDouble(ReadLine());

            WriteLine("Enter employee last name: ");
            string lastname = ReadLine();

            WriteLine("Enter employee first name: ");
            string firstname = ReadLine();

            WriteLine("Enter position: ");
            string pos = ReadLine();

            e = new Employee(empNum, s, lastname, firstname, pos);
        }
        static void modifyEmployee(ref Employee e)
        {
            WriteLine("Would you like to update \n 1. Employee Number \n 2. Last Name \n 3. First Name \n 4. Position \n 5. Salary");
            int userInput = Convert.ToInt32(ReadLine());

            if (userInput == 1)
            {
                WriteLine("Enter the new Employee Number: ");
                int newNum = Convert.ToInt32(ReadLine());
                e.EmployeeNumber = newNum;
            }
            else if (userInput == 2)
            {
                WriteLine("Enter the corrected last name: ");
                string lname = ReadLine();
                e.LastName = lname;
            }
            else if (userInput == 3)
            {
                WriteLine("Enter the corrected first name: ");
                string fname = ReadLine();
                e.FirstName = fname;
            }
            else if (userInput == 4)
            {
                WriteLine("Enter the corrected job title: ");
                string pos = ReadLine();
                e.Position = pos;
            }
            else if (userInput == 5)
            {
                WriteLine("Enter the corrected Salary: ");
                double sal = Convert.ToDouble(ReadLine());
                e.Salary = sal;
            }
            else
            {
                WriteLine("You input an invalid number");
            }
        }
    }
}