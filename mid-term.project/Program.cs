namespace mid_term.project
 {
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, street, city, zip, state, travelDate;

            // Greet the user
            WelcomePrompt();

            // Within the main Collect user information
            // Name 
            // Address 
            // Date of travel
            WriteLine("Please enter you name");
            name = ReadLine();
            WriteLine("Please enter your street name and house number");
            street = ReadLine();
            WriteLine("Please enter your city");
            city = ReadLine();
            WriteLine("Please enter your state");
            state = ReadLine();
            WriteLine("Please enter your zip code");
            zip = ReadLine();
            WriteLine("When is your intended date of travel?");
            travelDate = ReadLine();
            
            //TO DO
            decimal bagCost = GetBagData();
            

            // Create method to collect bag data (think about returning values and passing values.
            //     This is up to you on how you want to handle the data)

            // Request number of bags

            // Calculate baggage total

            // Calculate baggage total amount based on $25 a bag

            // You are required to use a switch or if/else within this method.
            //     The user could say they don’t want to check bags. So ask if they have bags to check or not.

            // Return total to main

            // Create method to collect seats

            // Request number of seats

            // Calculate seat total

            // Calculate seat total amount based on $30 a seat

            // You are required to use an if/else or switch. The user can say they don’t want to pay for seats.

            // Return total to main

            // Create receipt that shows the subtotal, tax at 5%, and grand total.
            //     Your receipt should have more than just data, add some formatting to the receipt.
            //     Maybe *** or color. Also make sure you format currency with $
        }

        static void WelcomePrompt()
        {
            WriteLine("Welcome to MacAire. To get started, let's get some informatin about yourself");
        }
        static decimal GetBagData()
        {
            int bags;
            decimal bagCost = 0m;

            WriteLine("How many bags do you plan on bringing? Price per bag is $25");
            bags = Convert.ToInt32(ReadLine());

            while (bags == 0)
            {
                WriteLine("Please enter a positive integer");
                WriteLine("How many bags do you plan on bringing? Price per bag is $25");
                bags = Convert.ToInt32(ReadLine());
            }
            if (bags < 1)
            {
                bagCost = 0m;
                WriteLine("No charge for baggage!");
                return bagCost;
            }       
            else
            {
                bagCost = bags * 25m;
                WriteLine("Fee for baggage will be {0:C}", bagCost);
                return bagCost;
            }
            




        }
    }
 }