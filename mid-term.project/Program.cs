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

            // Within the main Collect user information // Name // Address // Date of travel
            WriteLine("Please enter you name: ");
            name = ReadLine();
            WriteLine("Please enter your street name and house number: ");
            street = ReadLine();
            WriteLine("Please enter your city: ");
            city = ReadLine();
            WriteLine("Please enter your state: ");
            state = ReadLine();
            WriteLine("Please enter your zip code: ");
            zip = ReadLine();
            WriteLine("When is your intended date of travel? ");
            travelDate = ReadLine();

            //TO DO
            // Create method to collect bag data (think about returning values and passing values. Request number of bags. Calculate baggage total. Calculate baggage total amount based on $25 a bag
            decimal bagCost = GetBagCost();

            // Create method to collect seats
            decimal seatCost = GetSeatCost(travelDate);

            decimal totalCost = GetTotal(bagCost, seatCost);

            DisplayReceipt(bags, seats, travelDate, bagCost, seatCost, totalCost, subTotal, tax);
            
            ReadKey();
        }

        static void WelcomePrompt()
        {
            WriteLine("Welcome to MacAire. To get started, let's get some information about yourself.");
        }
        static decimal GetBagCost()
        {
            int bags;
            decimal bagCost = 0m;

            WriteLine("How many bags do you plan on bringing? Price per bag is $25");
            bags = Convert.ToInt32(ReadLine());

            while (bags > 0) //     The user could say they don’t want to check bags. So ask if they have bags to check or not.
            {
                WriteLine("Please enter a positive integer");
                WriteLine("How many bags do you plan on bringing? Price per bag is $25");
                bags = Convert.ToInt32(ReadLine());
            }
            if (bags == 0)
            {
                bagCost = 0m;
                WriteLine("No charge for baggage!");
                return bagCost;
            }
            else
            {
                bagCost = bags * 25m;
                WriteLine("Fee for baggage will be {0:C}", bagCost);
                return bagCost + bags;
            }
        }
        static decimal GetSeatCost(string travelDate)
        {
            int seats = 0;
            decimal seatCost = 0m;

            WriteLine("How many seats are needed on your travel date of {0}?", travelDate); // Request number of seats
            // You are required to use an if/else or switch. The user can say they don’t want to pay for seats.
            seats = Convert.ToInt32(ReadLine());

            while (seats < 0)
            {
                WriteLine("Please enter a positive integer for the number of seats requested or zero if you do not want to pay for seats.");
                seats = Convert.ToInt32(ReadLine());
            }

            switch(seats)
            {
                case 0:
                    WriteLine("No charge for seats!");
                    break;

                case >= 1:
                    seatCost = seats * 30m;  // Calculate seat total amount based on $30 a seat
                    break;
            }
            return seatCost + seats;

        }
        static decimal GetTotal(decimal bagCost, decimal seatCost)
        {
            // Create receipt that shows the subtotal, tax at 5%, and grand total.
            //     Your receipt should have more than just data, add some formatting to the receipt.
            //     Maybe *** or color. Also make sure you format currency with $
            decimal tax = .05m;
            decimal totalCost;
            decimal subTotal = bagCost + seatCost;
            totalCost = subTotal + (subTotal * tax);
            return totalCost + subTotal + tax;
        }
        static void DisplayReceipt(int bags, int seats, string travelDate, decimal bagCost, decimal seatCost, decimal totalCost, decimal subTotal, decimal tax)
        {
            WriteLine("Thank you for choosing MacAire today, your receipt is below: ");
            WriteLine("You chose {0} bags and {1} seats for travel on {2}", bags, seats, travelDate);
            WriteLine("The bags cost {0:C} and the seats cost {1:C}", bagCost, seatCost);
            WriteLine("Your subtotal is {0:C} and your total today with {1:P} tax is {2:C} ", subTotal, tax, totalCost);
        }
    }
 }