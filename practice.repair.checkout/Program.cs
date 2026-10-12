namespace Practice.RepairCheckout
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
        
        int serviceCount = 0;
        decimal subtotal = 0m;


            string customerName = WelcomeStatement();
            
            // TODO: Read and validate the customer's name.
            // TODO: Create subtotal and serviceCount variables.
            // TODO: Repeat the menu until checkout. Add each selected service.
            // TODO: Read and validate the coupon answer.
            // TODO: Calculate discount and tax, then call PrintReceipt.
        }

        static string WelcomeStatement()
        {
            // TODO: Display your shop's greeting.
            WriteLine("Please enter your name: " );
            string? customerName = ReadLine();

            while (String.IsNullOrWhiteSpace(customerName))
            {
                WriteLine("Please enter a valid name: ");
                customerName = ReadLine();
            }
            WriteLine($"Welcome to Mac's Auto, {customerName}!");
            return customerName;
        }

        static int ReadMenuChoice()
        {
            // TODO: Show the menu and use TryParse in a validation loop.
            return 4; // Placeholder so the unfinished project compiles.
        }

        static decimal GetServicePrice(int choice)
        {
            // TODO: Use a switch to return the selected service's price.
            return 0m;
        }

        static decimal CalculateDiscount(decimal subtotal, bool hasCoupon)
        {
            // TODO: Apply the coupon eligibility rule and round the discount.
            return 0m;
        }

        static decimal CalculateTax(decimal taxableAmount)
        {
            // TODO: Calculate and round the tax.
            return 0m;
        }

        static void PrintReceipt(string customerName, int serviceCount,
            decimal subtotal, decimal discount, decimal tax)
        {
            // TODO: Calculate the final total and print the receipt.
        }
    }
}
