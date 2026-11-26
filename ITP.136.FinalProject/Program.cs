namespace ITP._136.FinalProject
{
    using static System.Console;
    internal class Program
    {
        /*  Final Project – Programming is FUN
            FIRST: Welcome to the end and time for you to have a little fun!
            Program: You come up with the idea and you design. */

        //Comments (20 points)
        //Multi-Line Comment at the beginning explaining what your program does (10 points)
        //Single-Line Comment on each method explaining what it does (10 points)

        //Loop – your choice (20 points)

        //Exception Handling (20 points)

        //Array or List (20 points)

        static void Main(string[] args)
        {
            int x;
            int number;
            DateTime apptDate;
            
            WriteLine("Hello, World!");


            PopulateOwner();

            PopulateVet();

            PopulatePet();

            PopulateAppt();

            int y = ValidateInt();

            DateTime z = ValidateDate();

            DisplayPets();

            DisplayOwners();

            DisplayVets();

            DisplayAppts();


        }



        // Methods here
        //Two Methods (40 points)
        //One must pass a value (20 points)
        //One must return a value (20 points)
        static void PopulateOwner()
        {
            WriteLine("MethodMan");
        }

        static void PopulateVet()
        {
            WriteLine("MethodMan");
        }

        static void PopulatePet()
        {
            WriteLine("MethodMan");
        }
        
        static void PopulateAppt()
        {
            WriteLine("MethodMan");
        }

        static int ValidateInt()
        {
            int number;
            WriteLine("MethodMan");
            number = Convert.ToInt32(ReadLine());
            return number;
        }

        static DateTime ValidateDate()
        {
            DateTime apptDate;
            WriteLine("MethodMan");
            apptDate = Convert.ToDateTime(ReadLine());
            return apptDate;
        }

        static void DisplayPets()
        {
            WriteLine("MethodMan");
        }
        
        static void DisplayOwners()
        {
            WriteLine("MethodMan");
        }

        static void DisplayVets()
        {
            WriteLine("MethodMan");
        }

        static void DisplayAppts()
        {
            WriteLine("MethodMan");
        }
    }
}
