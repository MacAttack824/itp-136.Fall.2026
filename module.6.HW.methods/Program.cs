namespace module._6.HW.methods
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call a method call WelcomeStatement
            welcomeStatement();

            // Call a method called magic number in which you pass the variable secretNumber 
            int secretNumber = 18;
            magicNumber(secretNumber);

            // Call a method called findArea that catches 2 numbers that the user enters the values for.
            findArea();

            // Call a method called localTaxRate that will return the tax rate entered by the user and assign to a variable called taxRate.
            double taxRate = localTaxRate();
            // Write the tax rate out within the Main and not the method.
            WriteLine("Your local tax rate is: " + taxRate);
            
        }// closes main

        static void welcomeStatement()
        // This method will print out “Welcome to My Method Examples”
        {
            WriteLine("Welcome to my Method Examples");
        }

        static void magicNumber(int secretNumber)
        {
            WriteLine("The secret number is: " + secretNumber);
        }

        static void findArea()
        // call a method called findArea that catches 2 numbers that the user enters the values for.
        // This method will multiply the two numbers and write the result to the console.
        {
            WriteLine("Please enter the first measurement as a whole number: ");
            int measurement1 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter the second measurement as a whole number: ");
            int measurement2 = Convert.ToInt32(ReadLine());

            int area = measurement1 * measurement2;
            WriteLine("The measurement area is: " + area);
        }
        static double localTaxRate()
        {
            // The method will ask user for their tax rate
            WriteLine("Please enter your local tax rate: ");
            double taxRate = Convert.ToDouble(ReadLine());
            // Return the value entered by the user
            return taxRate;
        }
    }
}
