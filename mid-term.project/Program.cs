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
            decimal seatCost = GetSeats();
            // Create method to collect bag count
            decimal bagCost = GetBags();
            // method to calculate total
            decimal totalCost = CalculateTotal(bagCost, seatCost, taxRate);

            DisplayReceipt(name, street, city, state, zip , travelDate, bagCost, seatCost, totalCost, taxRate);

            ReadKey();
        }
        static void WelcomePrompt()
        {
            WriteLine("Welcome to MacAire. To get started, let's get some information about yourself.");
        }
        static decimal GetSeats()
        {
            // use a while loop to loop through your code based on number of seats entered.
            int seatCounter = 0;
            decimal seatCost = 0m;                        
            WriteLine("Please enter how many seats you wish to purchase: Each seat is $30"); 
            int seats = Convert.ToInt32(ReadLine()); // convert default string input to integer
            while (seats < 0) // reject negative seat counts
            {
                WriteLine("Please enter a realistic number of travelers");
                seats = Convert.ToInt32(ReadLine());
            }
            
            string[] names = new string[seats];
            while (seatCounter < seats) // Loop through each seat to collect and request traveler name
            {
                WriteLine("Please enter the name of passenger {0} :", seatCounter + 1); // ask for name per traveler
                names[seatCounter] = ReadLine();
                
                seatCounter ++; //increment seatCounter for next iteration
            }
            WriteLine("Total travelers is {0}", seatCounter);
            WriteLine("Travels going are :");
            for (int x = 0; x < names.Length; x++)
                {
                WriteLine("{0}", names[x]);
                }
            switch(seats)
            {
                case 0:
                    WriteLine("No charge for seats!");
                    seatCost = 0m;
                    break;

                case >= 1:
                    seatCost = seats * 30m;  // Calculate seat total amount based on $30 a seat
                    break;
            }
            return seatCost;
        }
        static decimal GetBags()
        {
            WriteLine("Please enter the total number of bags that are traveling? Price per bag is $25");
            int bags = Convert.ToInt32(ReadLine());

            while (bags < 0) //     The user could say they don’t want to check bags. So ask if they have bags to check or not.
            {
                WriteLine("Please enter a positive integer or zero for no bags");
                WriteLine("How many bags do you plan on bringing? Price per bag is $25");
                bags = Convert.ToInt32(ReadLine());
            }
            if (bags == 0)
            {
                decimal bagCost = 0m;
                WriteLine("No charge for baggage!");
                return bagCost;
            }
            else
            {
                for (int x = 0; x < bags; x++)
                {
                    WriteLine("Is bag {0} a checked bag or carry-on bag?", x + 1);
                    string bagType = ReadLine();
                }
                
                decimal bagCost = bags * 25m;
                return bagCost;
            }
        }
        static decimal CalculateTotal(decimal bagCost, decimal seatCost, decimal taxRate)
        {
            decimal totalCost = 0m;
            decimal subTotal = bagCost + seatCost;
           
            totalCost = subTotal + (subTotal * taxRate); // calculate total with tax rate %
            return totalCost;

        }
        static void DisplayReceipt(string name, string street, string city, string state, string zip, string travelDate, decimal bagCost, decimal seatCost, decimal totalCost, decimal taxRate)
        {
            WriteLine("\n");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Thank you {0} for choosing MacAire today, your receipt is below: \n", name);
            WriteLine("****************************************************************");
            WriteLine("Traveling from {0}, {1}, {2} {3}", street, city, state, zip);
            WriteLine("You chose a travel date of {0}", travelDate);
            WriteLine("For seats, your cost is {0:C} and bags cost {1:C}", seatCost, bagCost);
            WriteLine("Subtotal ------{0:C} \nTax --{1:P0}-----{3:C} \nGrand total ---{2:C} ", seatCost + bagCost, taxRate, totalCost, (seatCost + bagCost) * taxRate);
            WriteLine("****************************************************************");
            ResetColor();
        }
    }
 }