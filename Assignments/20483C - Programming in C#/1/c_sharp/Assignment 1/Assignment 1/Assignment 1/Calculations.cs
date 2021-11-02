using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Calculations
    {
        public void Multiply2Values()
        {
            try {
                Console.WriteLine("Give me any number greater than 0.");
                int numOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Give me any number to multiply it with except for zero");
                int numTwo = int.Parse(Console.ReadLine());
                int result = numOne * numTwo;
                Console.WriteLine($"{numOne} x {numTwo} = {result}", result);

            }
            catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }

        }
        public void Divide2Values()
        {
            try {
                Console.WriteLine("Give me any number.");
                int numOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Give me any number to divide by except for zero");
                int numTwo = int.Parse(Console.ReadLine());
                int result = numOne / numTwo;
                Console.WriteLine($"{numOne} / {numTwo} = {result}", result);
            }

            catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }

        }
        public void Compare2Values()
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
        public void EvenOrOdd()
        {
            Console.WriteLine("Give me any integer.");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine($"{num} is an odd number");
            }
            else
            {
                Console.WriteLine($"{num} is an even number");
            }
        }
    }
}
