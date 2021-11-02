using System;
namespace Assignment_1
{
    class Driver
    {
        public void RunProgram()
        {
            Employee employee = new Employee();
            Student student = new Student();
            Calculations calculations = new Calculations();
            NumberGame numGame = new NumberGame();
            Game game = new Game();

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
                Console.WriteLine("9: Factorial");
                Console.WriteLine("10: Rock Paper Scissors");
                Console.WriteLine("11: Get Season");

                string optionStr = Console.ReadLine();
                int option = int.Parse(optionStr);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        employee.EmployeeIncome();
                        flag = true;
                        break;
                    case 2:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        student.PassOrFail();
                        flag = true;
                        break;
                    case 3:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        calculations.Multiply2Values();
                        flag = true;
                        break;
                    case 4:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        calculations.Divide2Values();
                        flag = true;
                        break;
                    case 5:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        calculations.Compare2Values();
                        flag = true;
                        break;
                    case 6:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        calculations.EvenOrOdd();
                        flag = true;
                        break;
                    case 7:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        numGame.NumberGuesser();
                        flag = true;
                        break;
                    case 8:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        numGame.PrimeNumberCheck();
                        flag = true;
                        break;
                    case 9:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        game.Factorial();
                        flag = true;
                        break;
                    case 10:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        game.RockPaperScissors();
                        flag = true;
                        break;
                    case 11:
                        Console.WriteLine("You have chosen option {0}", option, "\n");
                        game.GetSeason();
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
