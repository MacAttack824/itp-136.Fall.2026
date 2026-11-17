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
            Part[] partArray = null; // declare a Part array variable; no array created yet

            bool partsAdded = false; // quits adding parts when true

            while (true)             // loops through program so user can view parts and view detail on parts while program runs
            {
                WriteLine("Choose an option for parts: 1 - Add Parts, 2 - View Parts List, 3 - View Part Detail, 4- Exit"); // switch statement to make choices
                try
                {
                    int choice = Convert.ToInt32(ReadLine());
                    switch (choice)
                    {
                        case 1:                      // add parts class array
                            if (partsAdded == false) // validates parts added array
                            {
                                WriteLine("How many parts do you wish to enter? "); // Ask the user how many objects they wish to enter
                                numParts = Convert.ToInt32(ReadLine());  // stores user entered # to loop through entering objects to parts class
                                partArray = new Part[numParts];          // initialize new array with size given by user 'numParts'

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
                            if (partsAdded == false) // Allow parts to only be entered once
                            {
                                WriteLine("Add parts first!");
                            }
                            else // Give the user a menu of all parts
                            {
                                WriteLine("{0,8}{1,20}{2,20}{3,30}{4,20}", "Index", "Part Number", "Part Name", "Part Description", "Part Cost");
                                for (int y = 0; y < partArray.Length; y++)
                                {
                                    WriteLine("{0,8}{1,20}{2,20}{3,30}{4,20:C2}", y + 1, partArray[y].PartNumber, partArray[y].PartName, partArray[y].PartDescription, partArray[y].PartCost);
                                }
                            }
                            break;

                        case 3: // view part detail on selected part
                            if (partsAdded == false)
                            {
                                WriteLine("Add parts first!");
                            }
                            else // Give the user a menu of all parts
                            {
                                try // try block to test if array index is IN bounds
                                {
                                    WriteLine("Which part would you like to view detail on? "); // Ask the user which part they would like to view data on
                                    for (int z = 0; z < partArray.Length; z++)
                                    {
                                        WriteLine("{0,8}{1,20}{2,20}", z + 1, partArray[z].PartNumber, partArray[z].PartName); //shows basic list of parts on record
                                    }

                                    int selectedPart = Convert.ToInt32(ReadLine()); // initialize variable for user to select part from list

                                    partDisplay(partArray[selectedPart - 1]); //Create a method to print out the object selected by user values
                                }
                                catch (IndexOutOfRangeException e) // if selected array index is out of bounds
                                {
                                    WriteLine($"Please choose an existing part!"); // exception user response for array index out of bounds
                                }
                            }

                            break;

                        case 4: // exit program

                            return;

                        default:
                            WriteLine("Invalid menu selection. Choose 1 through 4."); // reprompt for valid input
                            break;
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Invalid choice, if you wish to end the program, press 4."); // reprompt for valid input
                }
            }
        }
        static void populatePart(ref Part p) // add values to fields of Part class
        {
            WriteLine("Enter the part number: ");
            string number = ReadLine();

            WriteLine("Enter the part name: ");
            string name = ReadLine();

            WriteLine("Enter the part description: ");
            string des = ReadLine();

            WriteLine("Enter the part cost: ");
            decimal cost = Convert.ToDecimal(ReadLine());

            p = new Part(number, name, des, cost); // Part constructor bits (how the class builds the object)
        }
        static void partDisplay(Part p) // display a single part only carries a single object from partArray[selectedPart - 1]
        {
            WriteLine("{0,12}{1,20}{2,30}{3,20}", "Part Number", "Part Name", "Part Description", "Part Cost");
            WriteLine("{0,12}{1,20}{2,30}{3,20:C2}", p.PartNumber, p.PartName, p.PartDescription, p.PartCost);  // p references the selected Part object; its properties provide the data to display
                                                                                                                // p.x displays the selected object field

        }
    }
}