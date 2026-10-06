namespace module._6.CW.Videopractice
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
        //     int a,b;

        //     WelcomeMessage();

        //     string inputString = "Y";

        //     for (int k = 0; k < 3; k++)
        //     {
        //         a = AskNumber();
        //         b = AskNumber();
        //         AddNumbers(a, b);

        //     }

        //     while (inputString == "Y"|| inputString == "y")
        //     {
        //         a = AskNumber();
        //         b = AskNumber();
        //         AddNumbers(a, b);
        //         WriteLine("Would you like to add more numbers? (Y/N)");
        //         inputString = ReadLine();
        //     }

        //     WriteLine("Thank you for trying the practice program!");
        //     ReadKey();
        // }
        
        // static void WelcomeMessage()
        // {
        //     WriteLine("Welcome to the Video Practice Program and classwork!");
        // }
        
        // static int AskNumber()
        // {
        //     WriteLine("Please enter a number:");
        //     int number = Convert.ToInt32(ReadLine());
        //     return number;
        // }
        // static void AddNumbers(int a, int b)
        // {
        //     int sum = a + b;
        //     WriteLine($"The sum of {a} and {b} is: {sum}");
        // }
        int menuSelection, keepGoing=1; ;
        double total = 0;

        while (keepGoing == 1)
            {
                WriteLine("Welcome to my hotel application!");
                WriteLine("1-Make Reservation\n2-add-ons\n3-parking\n4-Total");
                menuSelection = Convert.ToInt32(ReadLine());

                switch(menuSelection)
                {
                    case 1:
                        // total = total + reserveRoom();
                        total += reserveRoom();
                        break;
                    
                    case 2:
                        total += addOn();
                        break;

                    case 3:
                        total += parkingTotal();
                        break;

                    case 4:
                        WriteLine("Your total is {0:C}", total);
                        break;

                    default:
                        WriteLine("You did not make a valid selection");
                        break;
                }
                WriteLine("1 to continue 2 to end");
                keepGoing = Convert.ToInt32(ReadLine());

            }

            WriteLine("Thank you for using my reservation system");
            ReadKey();
        }// ends main

        static double reserveRoom()
        {
            string roomType;
            double cost;
            WriteLine("Would you like a king, queen, double, or suite?");
            roomType = ReadLine();
            if (roomType == "King" || roomType == "king")
            {
                cost = 175.25;
            }
            else if (roomType == "Queen" || roomType == "queen")
            {
                cost = 150.75;
            }
            else if (roomType == "Double" || roomType == "double")
            {
                cost = 115.35;
            }
            else if (roomType == "Suite" || roomType == "suite")
            {
                cost = 375.10;
            }
            else
                cost = 0;
            
            return cost;
        }
        static double addOn()
        {
            double cost = 0;
            string userInput;

            WriteLine("Would you like a fridge? $25 n/y");
            userInput = ReadLine();
            if (userInput == "y")
                cost += 25;
            WriteLine("Would you like waters? $10 n/y");
            userInput = ReadLine();
            if (userInput == "y")
                cost += 10;

            return cost;
        }



        static double parkingTotal()
        {
            double cost = 0;
            int days;

            WriteLine("Enter the number of days you need parking at $25 a day: ");
            days = Convert.ToInt32(ReadLine());

            cost = days * 25;
            return cost;
        }

    }
}