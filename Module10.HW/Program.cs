namespace Module10.HW
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Within the Main you will create 2 food objects by setting each of their property values. 
            Food food1 = new Food(); // create first instance of food class
            Food food2 = new Food(); // create second instance of food class

            WriteLine("Please Enter the Food #: "); 
            food1.FoodId = Convert.ToInt32(ReadLine()); //store food number
            WriteLine("Please Enter the Food Name: ");
            food1.FoodName = ReadLine();                //store food name
            WriteLine("Please Enter the Food Description: ");
            food1.FoodDescription = ReadLine();         //store food description
            WriteLine("Please Enter the Food Cost: ");
            food1.FoodCost = Convert.ToDouble(ReadLine());//store food cost

            WriteLine("Please Enter the Food #: ");
            food2.FoodId = Convert.ToInt32(ReadLine()); //store food number
            WriteLine("Please Enter the Food Name: ");
            food2.FoodName = ReadLine();                //store food name
            WriteLine("Please Enter the Food Description: ");
            food2.FoodDescription = ReadLine();         //store food description
            WriteLine("Please Enter the Food Cost: ");
            food2.FoodCost = Convert.ToDouble(ReadLine());//store food cost


            // You will then write out a header line and each of the food object to the console.
            WriteLine("{0,-10} {1,-15} {2,-25} {3,10}", "Id", "Name", "Description", "Cost"); // display headers
            WriteLine("{0,-10} {1,-15} {2,-25} {3,10:C2}", food1.FoodId, food1.FoodName, food1.FoodDescription, food1.FoodCost); //print the stored values of food object 1
            WriteLine("{0,-10} {1,-15} {2,-25} {3,10:C2}", food2.FoodId, food2.FoodName, food2.FoodDescription, food2.FoodCost); //print the stored values of food object 2

            ReadKey();
        }
    }
}
