namespace module._6.HW.methods
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call a method called WelcomeStatement
            WelcomeStatement();

            // Call a method called magic number in which you pass the variable secretNumber 
            int secretNumber = 18;
            MagicNumber(secretNumber);

            // Call a method called findArea that catches 2 numbers that the user enters the values for.
            int a, b;
            a = AskNumber();
            b = AskNumber();
            FindArea(a, b);

            // Call a method called localTaxRate that will return the tax rate entered by the user and assign to a variable called taxRate.
            double taxRate = LocalTaxRate();
            // Write the tax rate out within the Main and not the method.
            WriteLine("Your local tax rate is: " + taxRate);
            
            ReadKey();
        }// closes main

        static void WelcomeStatement()
        // This method will print out “Welcome to My Method Examples”
        {
            WriteLine("Welcome to my Method Examples");
        }

        static void MagicNumber(int secretNumber)
        {
            WriteLine("The secret number is: " + secretNumber);
        }

        static int AskNumber()
        {
            WriteLine("Please enter a whole number for the measurement: ");
            int measurement = Convert.ToInt32(ReadLine());
            return measurement;
        }
        static void FindArea(int a, int b)
        // This method will multiply the two numbers and write the result to the console.
        {
            int area = a * b;
            WriteLine("The measurement area is: " + area);
        }
        static double LocalTaxRate()
        {
            // The method will ask user for their tax rate
            WriteLine("Please enter your local tax rate: ");
            double taxRate = Convert.ToDouble(ReadLine());
            // Return the value entered by the user
            return taxRate;
        }
    }
}
