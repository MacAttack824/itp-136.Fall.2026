namespace mid_term.project
 {
    using System;
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, street, city, zip, state, travelDate;
            decimal taxRate = 0.05m;

            // Greet the user
            WelcomePrompt();

            // Within the main Collect user information // Name // Address // Date of travel
            WriteLine("Please enter your name: ");
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

            // Create method to collect seats
            decimal seatCost = GetSeatCost(travelDate);

            // Create method to collect bag data (think about returning values and passing values. Request number of bags. Calculate baggage total. Calculate baggage total amount based on $25 a bag
            decimal bagCost = GetBagCost();

            decimal totalCost = CalculateTotal(bagCost, seatCost, taxRate);

            DisplayReceipt(name, travelDate, bagCost, seatCost, totalCost, taxRate);

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

            while (bags < 0) //     The user could say they don’t want to check bags. So ask if they have bags to check or not.
            {
                WriteLine("Please enter a positive integer or zero for no bags");
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
                //WriteLine("Fee for baggage will be {0:C}", bagCost);
                return bagCost;
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
                    seatCost = 0m;
                    break;

                case >= 1:
                    seatCost = seats * 30m;  // Calculate seat total amount based on $30 a seat
                    //WriteLine("Fee for seats will be {0:C}\n", seatCost);
                    break;
            }
            return seatCost;
        }
        static decimal CalculateTotal(decimal bagCost, decimal seatCost, decimal taxRate)
        {
            decimal totalCost = 0m;
            decimal subTotal = bagCost + seatCost;
           
            totalCost = subTotal + (subTotal * taxRate);
            return totalCost;

        }
        static void DisplayReceipt(string name, string travelDate, decimal bagCost, decimal seatCost, decimal totalCost, decimal taxRate)
        {
            WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Thank you {0} for choosing MacAire today, your receipt is below: \n", name);
            WriteLine("****************************************************************");
            WriteLine("You chose a travel date of {0}", travelDate);
            WriteLine("For seats, your cost is {0:C} and bags cost {1:C}", seatCost, bagCost);
            WriteLine("Subtotal ======{0:C} \nTax ==========={1:P} \nGrand total ==={2:C} ", seatCost + bagCost, taxRate, totalCost);
            WriteLine("****************************************************************");
            Console.ResetColor();
        }
    }
 }