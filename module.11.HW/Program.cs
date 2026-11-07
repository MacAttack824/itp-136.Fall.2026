namespace module._11.HW;
using static System.Console;
class Program
{       // In this assignment you will create a calculator that will allow you to do math functions with 
        // two numbers entered by the user. The user will also choose the math function to be used. 
        // There should be try catch error handling on your math.
    static void Main(string[] args)
    {
        // 1. Create three decimal variables. Two will be used for input and one for output. 
        // 2. Ask the user to input values.

        while (true)
        {
            WriteLine("Please enter the first number:");
            string num1 = ReadLine();
            WriteLine("Please enter a second number: ");
            string num2 = ReadLine();
            decimal result = 0;
            if (num1 == "exit" || num2 == "exit")
            {
                break;
            }
            
            WriteLine("1 - Addition, 2 - Multiplication, 3 - Subtraction, 4 - Division");
            int maths = Convert.ToInt32(ReadLine());

            decimal number1 = Convert.ToDecimal(num1);
            decimal number2 = Convert.ToDecimal(num2);


            switch(maths)
            {
                case 1:
                    result = number1 + number2;
                    break;

                case 2:
                    result = number1 * number2;
                    break;

                case 3:
                    result = number1 - number2;
                    break;

                case 4:
                    result = number1 / number2;
                    break;

                default:
                    break;
            }




            WriteLine($"Numbers entered were {num1} and {num2}, result is {result}");
        }
        // 3) Ask user to choose which math operation to use (1 - Addition, 2 - Multiplication, 3 - Subtraction, 4 - Division)

        // 4) Use an IF or Switch statement to use the proper operation.

        // 5) Math operation will be surrounded by a try catch statement to catch and errors 

        // 6) Error should be output to the user.

        // 7) Answer should be output to the user if there is no error.

        // 8) Program must run without any errors.
    }
}
