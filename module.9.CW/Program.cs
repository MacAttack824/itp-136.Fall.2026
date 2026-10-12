namespace module._9.CW
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Stephens", "Jordan", "Gretsky", "Ronaldo" };

            //WriteLine(names[3]);

            for (int x = 0; x < names.Length; x++)
            {
                WriteLine(names[x]);
            }
            
            WriteLine(names.Length);

            int[] nums = { 1, 5, 8, 9};

            double[] price = {12.25, 25.62, 36.75, 42.67};

            for (int x = 0; x < nums.Length; x++)
            {
                WriteLine(nums[x]);
            }

            for (int x = 0; x < price.Length; x++)
            {
                WriteLine(price[x]);
            }

            for (int x = 0; x < price.Length; x++)
            {
                WriteLine("{0,10}{1,10}", names[x], price[x]);
            }

            ReadKey();
        }
    }
}
