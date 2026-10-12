namespace module._9.HW.Arrays
{
    using static System.Console;
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] makes = new string[5];
            string[] models = new string[5];
            double[] cost = new double[5];

            for (int x = 0; x < makes.Length; x++)
            {
                WriteLine("Please enter a car make: ");
                makes[x] = ReadLine();

                WriteLine("Please enter the car model: ");
                models[x] = ReadLine();

                WriteLine("Please enter the car's cost: ");
                cost[x] = Convert.ToDouble(ReadLine());
            }

            WriteLine("{0,12}{1,12}{2,12}", "Make", "Model", "Cost");

            for (int y = 0; y < makes.Length; y++)
            {
                WriteLine("{0,12}{1,12}{2,12:C2}", makes[y], models[y], cost[y]);
            }
            
            double max = cost.Max();

            int p = Array.IndexOf(cost, max);

            WriteLine(makes[p] + " " + models[p] + " is the most expensive car entered at a cost of: {0:C2}", cost[p]);

        ReadKey();   
        }
    }
}
