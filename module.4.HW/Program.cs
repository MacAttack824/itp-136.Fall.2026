namespace module._4.HW
{
    
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            string option, age;
            int sickCost, wellCost;
            string labs = null;
            // 1. Create a menu to include
            // a.Doctor – Sick Appointment
            // b.Doctor – Check - up

            WriteLine("Welcome to Mac's Medical, are you here for a sick appointment or a well check-up? Please enter 'sick' for Sick Appointment or 'well' for Check-up");

            option = (ReadLine());

            // 2.You will use a switch statement and have a case for each of the above.

            switch(option)
            {
                case "sick":
                    WriteLine("You have selected a sick appointment.");

                    WriteLine("Is the patient being seen today a child or an adult?");
                    age = ReadLine();

                    // a.Ask if child or adult(base visit child = $50, adult = 75)
                    // 3.Within Sick appointment(use if/ ese statements)

                    if (age == "child")
                    {
                        WriteLine("Base charge for a child is $50");
                        sickCost = 50;
                        
                        // b.Did the user have labs done(+$25)

                        WriteLine("Did the patient have any labs done today? Please enter 'yes' or 'no'.");
                        labs = ReadLine();

                        if (labs == "yes")
                        {
                            WriteLine("Labs were done today and there will be an additional charge of $25");
                            sickCost += 25;
                        }
                        WriteLine("The total cost for the sick appointment is {0:C}", sickCost);
                    }

                    else if (age == "adult")
                    {
                        WriteLine("Base charge for an adult is $75");
                        sickCost = 75;

                        // b.Did the user have labs done(+$25)

                        WriteLine("Did the patient have any labs done today? Please enter 'yes' or 'no'.");
                        labs = ReadLine();

                        if (labs == "yes")
                        {
                            WriteLine("Labs were done today and there will be an additional charge of $25");
                            sickCost += 25;
                        }
                    WriteLine("The total cost for the sick appointment is {0:C}", sickCost);
                    }
                    // c.Show out the total for the appointment and format to currency.

                    break;

                case "well":
                    WriteLine("You have selected a well check-up.");

                    WriteLine("Is the patient being seen today a child or an adult?");
                    age = ReadLine();

                    // 4.Within Check - up(use if/else statement)

                    if (age == "child")
                    {
                        WriteLine("The charge for a child is $75");
                        wellCost = 75;
               
                        WriteLine("The total cost for the well visit today is {0:C}", wellCost);
                    }
                    else if (age == "adult")
                    {
                        WriteLine("The charge for an adult is $100");
                        wellCost = 100;
                        
                        WriteLine("The total cost for the well visit today is {0:C}", wellCost);
                    }
                    // a.Ask if child or adult(child $75 and adult = 100)
                    // b.Show out the charge

                    break;
                
                default:
                    WriteLine("You have not selected a valid option.");
                    break;
            }
        }
    }
}
