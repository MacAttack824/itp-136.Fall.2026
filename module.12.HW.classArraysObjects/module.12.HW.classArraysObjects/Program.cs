using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace module._12.HW.classArraysObjects
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // For this assignment you will be creating an array of objects or a list of objects of car parts based on user input.

            WriteLine("Welcome to MacParts, (Not affiliated with MacTools)");

            // Create an array of parts objects

            int numParts;
            Part[] partArray = null;

            bool partsAdded = false; // quits adding parts when true

            while (true)
            {
                WriteLine("Choose an option for parts: 1 - Add Parts, 2 - View Parts List, 3 - View Part Detail, 4- Exit");
                int choice = Convert.ToInt32(ReadLine());
                switch (choice)
                {
                    case 1: // add parts class array
                        if (partsAdded == false)
                        {
                            WriteLine("How many parts do you wish to enter? "); // Ask the user how many objects they wish to enter
                            numParts = Convert.ToInt32(ReadLine());
                            partArray = new Part[numParts];

                            // Loop appropriately to collect the data needed to populate the objects in the array
                            for (int x = 0; x < partArray.Length; x++)
                            {
                                populatePart(ref partArray[x]);
                            }
                            partsAdded = true;
                        }
                        else
                        {
                            WriteLine("No parts can be added at this time!");
                        }

                        break;

                    case 2: // view parts list
                        if (partsAdded == false)
                        {
                            WriteLine("Add parts first!");
                        }
                        else // Give the user a menu of all parts
                        {
                            WriteLine("{0,12}{1,15}{2,20}{3,10}", "Part Number", "Part Name", "Part Description", "Part Cost");
                            for (int y = 0; y < partArray.Length; y++)
                            {
                                WriteLine("{0,8}{1,12}{2,15}{3,20}{4,10:C2}", y + 1, partArray[y].PartNumber, partArray[y].PartName, partArray[y].PartDescription, partArray[y].PartCost);
                            }
                        }
                        break;

                    case 3: // view part detail on selected part

                        WriteLine("Which part would you like to view detail on? "); // Ask the user which part they would like to view data on
                        for (int z = 0; z < partArray.Length; z++)
                        {
                            WriteLine("{0,8}{1,12}{2,15}{3,20}{4,10:C2}", z + 1, partArray[z].PartNumber, partArray[z].PartName, partArray[z].PartDescription, partArray[z].PartCost);
                        }

                        int selectedPart = Convert.ToInt32(ReadLine());

                        partDisplay(partArray[selectedPart - 1]); //Create a method to print out the object selected by user values


                        break;

                    case 4: // exit program

                        return;

                    default:
                        break;
                }
            }
            ReadKey();
        }
        static void populatePart(ref Part p)
        {
            WriteLine("Enter the part number: ");
            string number = ReadLine();

            WriteLine("Enter the part name: ");
            string name = ReadLine();

            WriteLine("Enter the part description: ");
            string des = ReadLine();

            WriteLine("Enter the part cost: ");
            decimal cost = Convert.ToDecimal(ReadLine());

            p = new Part(number, name, des, cost);
        }
        static void partDisplay(Part p)
        {
            WriteLine("{0,12}{1,15}{2,20}{3,10}", "Part Number", "Part Name", "Part Description", "Part Cost");
            WriteLine("{0,12}{1,15}{2,20}{3,10:C2}", p.PartNumber, p.PartName, p.PartDescription, p.PartCost);
        }
    }
}