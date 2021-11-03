using System;
namespace Assignment_1
{
    public class Game
    {
        public void Factorial()
        {
            int factorial(int numToFactor)
            {
                if (numToFactor == 0) return 1;
                return numToFactor * factorial(numToFactor - 1);
            }
            Console.WriteLine("Provide me with a positive integer:\n");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = factorial(num);
            Console.WriteLine("{0}! = {1}\n", num, n);
        }

        public void RockPaperScissors()
        {
            string AIChoice = "";
            string userChoice;
            int randomNumber;
            Console.WriteLine("Rock, Paper, Scissors, Shoot! Enter 1, 2, or 3.\n");
            Console.WriteLine("1.) Rock\n2.) Paper\n3.) Scissors\n");

            userChoice = Console.ReadLine();

            Random random = new Random();

            randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:

                    AIChoice = "Rock";
                    Console.WriteLine("AI chooses {0}", AIChoice);

                    if (userChoice == "1")
                    {
                        Console.WriteLine("DRAW!\n");
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine("You win!\n");
                    }
                    else
                    {
                        Console.WriteLine("You lose!\n");
                    }
                    break;

                case 2:
                    AIChoice = "Paper";
                    Console.WriteLine("AI chooses {0}", AIChoice);

                    if (userChoice == "1")
                    {
                        Console.WriteLine("You lose!\n");
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine("DRAW!\n");
                    }
                    else
                    {
                        Console.WriteLine("You win!\n");
                    }
                    break;

                case 3:
                    AIChoice = "Scissors";
                    Console.WriteLine("AI chooses {0}", AIChoice);

                    if (userChoice == "1")
                    {
                        Console.WriteLine("You win!\n");
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine("You lose!\n");
                    }
                    else
                    {
                        Console.WriteLine("Draw!\n");
                    }
                    break;

                default:
                    break;
            }
        }

        int CaptureMonthInput()
        {
            int month;
            Console.WriteLine("Enter a month by integer value: (e.g. 1 - 12)");
            month = Convert.ToInt32(Console.ReadLine());
            return month;
        }

        int CaptureDayInput()
        {
            int day;
            Console.WriteLine("Enter a day by integer value: (e.g. 1 - 31)");
            day = Convert.ToInt32(Console.ReadLine());
            return day;
        }

        public void GetSeason()
        {

        string[] months = { "January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", "December" };

        int[] days = new int[31];
        for (int daysIter = 0; daysIter < 31; daysIter++)
        {
            days[daysIter] = daysIter;
        }

        string[] seasons = { "Winter", "Spring", "Summer", "Fall" };

        int monthInYear = CaptureMonthInput();
        int dayInMonth = CaptureDayInput();
            )
        try
        {
            if (monthInYear < 1 || monthInYear > 12)
            {
                GetSeason();
            }
            if (dayInMonth < 1 || dayInMonth > 31)
            {
                GetSeason();
            }

            switch (monthInYear)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Season: {0}.", seasons[0]);
                    break;
                case 3:
                    if (dayInMonth < 20)
                    {
                        Console.WriteLine("Season: {0}.", seasons[0]);
                    }
                    else
                    {
                        Console.WriteLine("Season: {0}.", seasons[1]);
                    }
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Season: {0}.", seasons[1]);
                    break;
                case 6:
                    if (dayInMonth < 20)
                    {
                        Console.WriteLine("Season: {0}.", seasons[1]);
                    }
                    else
                    {
                        Console.WriteLine("Season: {0}.", seasons[2]);
                    }
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Season: {0}.", seasons[2]);
                    break;
                case 9:
                    if (dayInMonth < 22)
                    {
                        Console.WriteLine("Season: {0}.", seasons[2]);
                    }
                    else
                    {
                        Console.WriteLine("Season: {0}.", seasons[3]);
                    }
                    break;
                case 10:
                case 11:
                    Console.WriteLine("Season: {0}.", seasons[3]);
                    break;
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
            GetSeason();
        }
        }
    }
}