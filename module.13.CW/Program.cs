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

            WriteLine(salList);



            ReadKey();

        }
    }
}
