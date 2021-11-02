using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                Console.WriteLine("\n Please input an option number (1-8), 9 to exit.");
                Console.WriteLine("1: Calculate employee income.");
                Console.WriteLine("2: Calculate if you passed or failed a class.");
                Console.WriteLine("3: Multiply two values.");
                Console.WriteLine("4: Divide two values.");
                Console.WriteLine("5: Compare two values.");
                Console.WriteLine("6: Determine if a number is odd or even.");
                Console.WriteLine("7: Number Guesser");
                Console.WriteLine("8: Prime Number Checker");
                Console.WriteLine("9: Exit");

                string optionStr = Console.ReadLine();
                int option = int.Parse(optionStr);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        Employee.EmployeeIncome();
                        flag = true;
                        break;
                    case 2:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        Student.PassOrFail();
                        flag = true;
                        break;
                    case 3:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        Calculations.Multiply2Values();
                        flag = true;
                        break;
                    case 4:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        Calculations.Divide2Values();
                        flag = true;
                        break;
                    case 5:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        Calculations.Compare2Values();
                        flag = true;
                        break;
                    case 6:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        Calculations.EvenOrOdd();
                        flag = true;
                        break;
                    case 7:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        NumberGame.NumberGuesser();
                        flag = true;
                        break;
                    case 8:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        NumberGame.PrimeNumberCheck();
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("You did not select a valid option.");
                        flag = false;
                        break;
                }
            } while (flag);
        }
    }
}
