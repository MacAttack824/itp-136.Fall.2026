namespace module10CW
{
using Week10CW;
using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.EmployeeId = 1234;
            emp1.LastName = "Stephens";
            emp1.FirstName = "David";

            emp2.EmployeeId = 2323;
            emp2.LastName = "Jordan";
            emp2.FirstName = "Michael";



            WriteLine("{0,10} {1,10} {2,10}", "EmployeeId", "Last", "First");
            WriteLine("{0,10} {1,10} {2,10}", emp1.EmployeeId, emp1.LastName, emp1.FirstName);
            WriteLine("{0,10} {1,10} {2,10}", emp2.EmployeeId, emp2.LastName, emp2.FirstName);


            emp1.LastName = "Smith";

            WriteLine("{0,10} {1,10} {2,10}", emp1.EmployeeId, emp1.LastName, emp1.FirstName);

            WriteLine("Enter Employee #");
            emp2.EmployeeId = Convert.ToInt32(ReadLine());

            WriteLine("Eneter Employye Last Name");
            emp2.LastName = ReadLine();

            WriteLine("Enter Employee First Name");
            emp2.FirstName = ReadLine();

            WriteLine("{0,10} {1,10} {2,10}", emp2.EmployeeId, emp2.LastName, emp2.FirstName);

            ReadKey();
        }
    }
}
