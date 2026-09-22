namespace classwork._9._16
{
    using System.Collections;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLine("Enter two numbers.");
            // Write("Enter First Number:");
            // int firstNumber = int.Parse(ReadLine());
            // Write("Enter second number:");
            // int secondNumber = int.Parse(ReadLine());
            // int biggerNumber = firstNumber;
            // if (secondNumber > firstNumber)
            // {
            //     biggerNumber = secondNumber;
            // }
            // WriteLine("The bigger number is: {0}", biggerNumber);
            
            
            // int x = 2;
            // if (x > 3)
            // {
            //     WriteLine("x is greater than 3");
            // }
            // else
            // {
            //     WriteLine("x is not greater than 3");
            // }

            // char ch  = 'X';
            // if (ch == 'A' || ch == 'a')
            // {
            //     WriteLine("Vowel [ei]");
            // }

            // else if (ch == 'E' || ch == 'e')
            // {
            //     WriteLine("Vowel [i:]");
            // }

            // else if (ch == 'I' || ch == 'i')
            // {
            //     WriteLine("Vowel [ai]");
            // }

            // else if (ch == 'O' || ch == 'o')
            // {
            //     WriteLine("Vowel [ou]");
            // }

            // else if (ch == 'U' || ch == 'u')
            // {
            //     WriteLine("Vowel [ju:]");
            // }

            // else
            // {
            //     WriteLine("Consonant");
            // }

            // // switch(integer_selector)
            // // {
            // //     case integer_value_1:
            // //         statements;
            // //         break;

            // //     case integer_value_2:
            // //         statements;
            // //         break;
                
            // //     default:
            // //         statements;
            // //         break;

            // int number = 6;

            // switch(number)
            // {
            //     case 1:
            //     case 4:
            //     case 6:
            //     case 8:
            //     case 9:
            //     case 10:
            //         Console.WriteLine("The number is not prime!"); break;
            //     case 2:
            //     case 3:
            //     case 5:
            //     case 7:
            //         Console.WriteLine("The number is prime!"); break;
            //     default:
            //         Console.WriteLine("Unknown number!"); break;
            // }

            // WriteLine("Enter 3 numbers at random and I will sort them  out");
            // WriteLine("Enter the first number");

            // int num1 = int.Parse(ReadLine());

            // WriteLine("Enter the second number");
            // int num2 = int.Parse(ReadLine());

            // WriteLine("Enter the third number");
            // int num3 = int.Parse(ReadLine());

            // if (num1 > num2)
            // {
            //     if (num2 > num3)
            //     {
            //         WriteLine($"{num1}, {num2}, {num3}");
            //     }
            //     else if (num1 > num3)
            //     {
            //         WriteLine($"{num1}, {num3}, {num2}");
            //     }
            //     else
            //     {
            //         WriteLine($"{num3}, {num1}, {num2}");
            //     }
            // }
            // else if (num2 > num1)
            // {
            //     if (num1 > num3)
            //     {
            //         WriteLine($"{num2}, {num1}, {num3}");
            //     }
            //     else if (num2 > num3)
            //     {
            //         WriteLine($"{num2}, {num3}, {num1}");
            //     }
            //     else
            //     {
            //         WriteLine($"{num3}, {num2}, {num1}");
            //     }
            // }



            WriteLine("Enter a number 0-9");
            string number = ReadLine();
            switch(number)
            
            {
                case "1":
                    WriteLine("One");
                    break;
                case "2":
                    WriteLine("Two");
                    break;
                case "3":
                    WriteLine("Three");
                    break;
                case "4":
                    WriteLine("Four");
                    break;
                case "5":
                    WriteLine("Five");
                    break;
                case "6":
                    WriteLine("Six");
                    break;
                case "7":
                    WriteLine("Seven");
                    break;
                case "8":
                    WriteLine("Eight");
                    break;
                case "9":
                    WriteLine("Nine");
                    break;
                case "0":
                    WriteLine("Zero");
                    break;
                default:
                    WriteLine("Please enter a valid value:");
                    break;
            }






        }
    }
}
