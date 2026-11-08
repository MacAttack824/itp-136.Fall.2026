namespace module._11.HW;
using static System.Console;
class Program
{       // In this assignment you will create a calculator that will allow you to do math functions with 
        // two numbers entered by the user. The user will also choose the math function to be used. 
        // There should be try catch error handling on your math.
    static void Main(string[] args)
    {  
        while (true)
        {
            string num1 = GetNumber("Please enter the first number:"); // call method to get a number
            if (num1 == "exit") // exits if user wishes
            {
                break;
            }
            string num2 = GetNumber("Please enter the second number:"); // call method to get a number
            if (num2 == "exit") // exits if user wishes
            {
                break;
            }
            try // try block to test for exceptoins
            {
                decimal number1 = Convert.ToDecimal(num1); // convert string input to decimal in case user entered 'bacon'
                decimal number2 = Convert.ToDecimal(num2);
                decimal result;                            // name variables

                result = Mathing(number1, number2);        // call switch method to work the math and numbers

                WriteLine($"Numbers entered were {num1} and {num2}, the result is {result}"); // result output to user
            }
            catch (Exception e) // if try doesn't work, explain to user the error
            {
                WriteLine($"You've found an error!!! : {e.Message}");
            }
        }
    }
    static string GetNumber(string prompt)
    {
        WriteLine(prompt); // ask for first number input 
        string value = ReadLine();
        return value;
    }

    static decimal Mathing(decimal number1, decimal number2) // method outside of main
    {
        WriteLine("1 - Addition, 2 - Multiplication, 3 - Subtraction, 4 - Division"); //switch to choose math operation
        string maths = ReadLine(); // use switch numbers 1-4 to enter an integer
        if (maths == "exit")
        {
            Environment.Exit(0);
            return 0;
        }
        else
        {
            int operation = Convert.ToInt32(maths);
            decimal result;

            switch(operation)
            {
                case 1:
                    result = number1 + number2;
                    return result;

                case 2:
                    result = number1 * number2;
                    return result;

                case 3:
                    result = number1 - number2;
                    return result;

                case 4:
                    result = number1 / number2;
                    return result;
                
                default:
                    throw new ArgumentException("Invalid maths selected."); // if user does not choose 1-4, throws argument exception
            }
        }
    }
}
