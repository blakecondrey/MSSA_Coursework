using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Calculations
    {
        public static void Multiply2Values()
        {
            try {
                Console.WriteLine("Give me any number greater than 0.");
                float numOne = float.Parse(Console.ReadLine());
                Console.WriteLine("Give me any number to multiply it with except for zero");
                float numTwo = float.Parse(Console.ReadLine());
                float result = numOne * numTwo;
                Console.WriteLine($"{numOne} x {numTwo} = {result}", result);

            }
            catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }

        }
        public static void Divide2Values()
        {
            try {
                Console.WriteLine("Give me any number.");
                float numOne = float.Parse(Console.ReadLine());
                Console.WriteLine("Give me any number to divide by except for zero");
                float numTwo = float.Parse(Console.ReadLine());
                float result = numOne / numTwo;
                Console.WriteLine($"{numOne} / {numnTwo} = {result}", result);
            }

            catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }

        }
        public static void Compare2Values()
        {
            Console.WriteLine("Give me any number.");
            float compare1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number.");
            float compare2 = float.Parse(Console.ReadLine());

            if (compare2 > compare1)
            {
                Console.WriteLine($"{compare2} is greater than {compare1}.");
            }
            else if (compare2 == compare1)
            {
                Console.WriteLine($"{compare2} is equal to {compare1}.");
            }
            else
            {
                Console.WriteLine($"{compare2} is less than {compare1}.");
            }
        }
        public static void EvenOrOdd()
        {
            Console.WriteLine("Give me any integer.");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine($"{number1} is an odd number");
            }
            else
            {
                Console.WriteLine($"{number1} is an even number");
            }
        }
    }
}
