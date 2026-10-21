namespace bonus.loops;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        // use a while loop to loop through your code based on number of seats entered.
        int seatCounter = 0;
        int seats = 0;
        int bags = 0;
        int totalBags = 0;
        
        WriteLine("Please enter how many seats you wish to purchase: "); 
        seats = Convert.ToInt32(ReadLine()); // convert default string input to integer

         while (seats > seatCounter) // Loop through each seat to collect and accumulate traveler baggage
        {
            WriteLine("How many bags does passenger {0} need?", seatCounter +1); // ask for bag count per traveler
            bags = Convert.ToInt32(ReadLine());

            totalBags = totalBags + bags; // running total

            seatCounter ++; //increment seatCounter for next iteration
        }
        WriteLine("Total bags for your traveling party is {0}", totalBags);










    }
}
