namespace HW.Week._5
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            // In this assignment you will create a program that will count from a starting number ***entered by the user*** and finish at another number entered by the user. 
            //A While Loop or a For Loop will be used.

            // 1.A variable will be created for Start Number, End Number, and Counter
            int startNumber, endNumber, countNumber, counter;
            counter = 0;

            WriteLine("Please enter a number to start counting from:  ");
            startNumber = Convert.ToInt32(ReadLine());

            WriteLine("Please enter a number to count to from your starting number:  ");
            endNumber = Convert.ToInt32(ReadLine());

            while (startNumber >= endNumber)
            {
                WriteLine("The starting number must be less than the ending number. Please enter valid numbers.");
                WriteLine("Please enter a number to start counting from:  ");
                startNumber = Convert.ToInt32(ReadLine());
                WriteLine("Please enter a number to count to from your starting number:  ");
                endNumber = Convert.ToInt32(ReadLine());
            }

            countNumber = endNumber - startNumber;

            // 2.A While Loop or a For Loop is used
            for (counter = startNumber + 1; counter <= endNumber; counter++) // 4.The Counter will be incremented by 1 until the loop completes
            {
                WriteLine("The counter is now at: " + counter);
            }

            // 3.The Start Number and End Number will be output
            WriteLine("The counting has completed!");
            WriteLine("The starting number is: " + startNumber);
            WriteLine("The ending number   is: " + endNumber);
            WriteLine("The counter amount  is: " + countNumber);

            ReadKey();
            
        }
    }
}
