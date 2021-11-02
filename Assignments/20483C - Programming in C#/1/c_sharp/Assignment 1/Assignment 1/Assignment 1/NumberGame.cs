using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_1
{
    public class NumberGame
    {
        public static void NumberGuesser()
        {
            Random random = new Random();
            int guess = 0;
            string guesserMsg = "Guess a number between 1 & 10\n";

            // set range from 1 - 10
            int correctNum = random.Next(1, 10);

            // store variable for allowed attempts
            int allowedAttempts = 3;

            // initialize variable to capture attempts
            int numOfAttempts = 0;
            Console.Write(guesserMsg);

            // until guess is correct
            while(guess != correctNum)
            {
                // try -> catch to ensure valid entry
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > correctNum)
                    {
                        Console.WriteLine("Your guess was too high.");
                    }
                    else
                    {
                        Console.Write("Your guess was too low.");
                    }
                }
                catch
                {
                    Console.WriteLine("Guess MUST be a valid number.");
                    // returns allowed attempts to previous amount
                    allowedAttempts++;
                }

                // increment attempts
                numOfAttempts++;

                // once number of attempts hits 3, reveal correct number
                if (numOfAttempts == allowedAttempts)
                {
                    Console.WriteLine($"\nCorrect number was: {correctNum}");
                    break;
                }
                // display to user number of attempts remaining.
                Console.WriteLine($"\n{allowedAttempts - numOfAttempts} attempts remaining.");
            }
        }

        public static bool PrimeNumberCheck()
        {
            try
            {
                Console.WriteLine("Provide an integer: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num <= 1)
                {
                    Console.WriteLine("NOT Prime.");
                    return false;
                }
                if (num == 2)
                {
                    Console.WriteLine("PRIME!");
                    return true;
                }

                // trial division
                /*
                 * Divide integer N by each integer M that is greater than 1 and
                 * less than or equal to the square root of N. If result of these
                 * divisions is an integer, then N is NOT a prime.
                 * Else, it IS prime.
                 */
                var threshold = Math.Ceiling(Math.Sqrt(num));

                for (int i = 2; i <= threshold; ++i)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("NOT Prime.");
                        return false;
                    }
                    Console.WriteLine("PRIME!");
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("Input MUST be a valid number.");
            }
            Console.WriteLine("PRIME!");
            return true;
        }
    }
}
