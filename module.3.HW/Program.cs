namespace module._3.HW
{
    using static System.Console;
    class Program
    {
        // For this assignment you will be calculating the total amount for a repair shop bill.
        static void Main(string[] args)
        {
            double oilChange = 0;
            double tire = 0;
            double inspection = 0;
            double taxRate = .06;
            double subTotal = 0;

            // You need a greeting
            WriteLine("Welcome to Mac of All Trades! Your one stop shop for all repairs and maintenance!");

            // Ask the user to enter the total for oil change
            WriteLine("What was the total for your oil change?");
            oilChange = double.Parse(ReadLine());

            // Ask the user to enter the total for tires
            WriteLine("What was the total cost for the tires?");
            tire = double.Parse(ReadLine());

            // Ask the user to enter the total for inspection
            WriteLine("What was the cost of the state inspection?");
            inspection = double.Parse(ReadLine());

            // You will provide the user with a subtotal (format as currency)
            subTotal = oilChange + tire + inspection;

            WriteLine("Your subtotal before tax is {0:C} ", subTotal);


            // Calculate the tax and output to console for a 6 % tax rate(format as currency)
            WriteLine("Tax is {0:C} ", subTotal * taxRate);


            // Calculate and output the grand total of the bill. (format as currency)
            WriteLine("Your grand total is {0:C} ", subTotal + (subTotal * taxRate));

            ReadKey();


        }
    }
}
