namespace Week11CW.followAlong
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exception handling
            int num1, num2;
            double total;

            WriteLine("Enter your first number: ");
            num1 = Convert.ToInt32(ReadLine());

            WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(ReadLine());

            try
            {
                total = num1 / num2;
                WriteLine("The total is: " + total);
            }
            catch (Exception e)
            {
                WriteLine(e.ToString());
            }
            try
            {
                total = num1 / num2;
                WriteLine("The total is: " + total);
            }
            catch (DivideByZeroException e)
            {
                WriteLine("\nDivide by Zero NOT Allowed!");
                WriteLine("\nException Caught: " + e);
            }

            WriteLine("Index out of range Code");

            string[] numberArray = { "Gretsky", "Jordan", "Ruth" };

            try
            {
                WriteLine("Which element do you want to see?");
                int elementNumber = Convert.ToInt32(ReadLine());

                WriteLine(numberArray[elementNumber]);
            }
            catch(IndexOutOfRangeException e)
            {
                //WriteLine(e);
                WriteLine("\nYou must enter a value between 0 and 2");
            }





            ReadKey();

        }
    }
}
