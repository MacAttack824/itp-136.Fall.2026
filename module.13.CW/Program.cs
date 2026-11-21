namespace module._13.CW
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Salary> salList = new List<Salary>();
            List<Commission> comList = new List<Commission>();

            salList.Add(new Salary(1313, "David Stephens", 50000));
            salList.Add(new Salary(2323, "Michael Jordan", 1050000));

            comList.Add(new Commission(5050, "Elon Musk", 800000));
            comList.Add(new Commission(1001, "William Gates", 1890000));

            foreach (Commission co in comList)
            {
                WriteLine(co.EmployeeNum + "\t" + co.FullName + "\t" + co.Sales.ToString("C2"));
            }

            foreach (Salary sa in salList)
            {
                WriteLine(sa.EmployeeNum + "\t" + sa.FullName + "\t" + sa.SalaryAmount.ToString("C2"));
            }

            WriteLine("How many Salaried Employees do you wish to enter: ");
            int inputAnswer = Convert.ToInt32(ReadLine());

            for (int x = 0; x < inputAnswer; x++)
            {
                WriteLine("Please enter the employee number");
                int empNum = Convert.ToInt32(ReadLine());

                WriteLine("Please enter the employee name");
                string fn = ReadLine();

                WriteLine("Please enter the employee salary");
                double sa = Convert.ToDouble(ReadLine());

                salList.Add(new Salary(empNum, fn, sa));

            }
            foreach (Salary sa in salList)
            {
                WriteLine(sa.EmployeeNum + "\t" + sa.FullName + "\t" + sa.SalaryAmount.ToString("C2"));
            }

            ReadKey();
        }
    }
}
