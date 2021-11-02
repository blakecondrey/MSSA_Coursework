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
                Console.WriteLine("");
                Console.WriteLine("Please input an option number (1-6), 7 to exit.");
                Console.WriteLine("1: Calculate the income of an employee.");
                Console.WriteLine("2: Calculate if you passed or failed a class.");
                Console.WriteLine("3: Multiply two values.");
                Console.WriteLine("4: Divide one value by another.");
                Console.WriteLine("5: Compare two values and return the biggest value.");
                Console.WriteLine("6: Determine if a number is odd or even.");
                Console.WriteLine("7: Exit");

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
                        Console.WriteLine("You have chosen to exit.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You did not select a valid option.");
                        break;
                }
            } while (flag);
        }
    }
}
