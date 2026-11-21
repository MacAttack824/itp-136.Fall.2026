namespace module._13.CW
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Salary> salList = new List<Salary>();

            salList.Add(new Salary(1313, "David Stephens", 50000));
            salList.Add(new Salary(2323, "Michael Jordan", 1050000));

            WriteLine("{0,12}{1,25}{2,20}", "Employee #", "Employee Name", "Employee Salary");
            foreach (Salary sa in salList)
            {
                WriteLine("{0,12}{1,25}{2,20:c2}", sa.EmployeeNum, sa.FullName, sa.SalaryAmount);
            }



            ReadKey();

        }
    }
}
