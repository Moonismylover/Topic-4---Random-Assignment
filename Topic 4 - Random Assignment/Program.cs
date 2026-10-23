using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Topic_4___Random_Assignment
{
    internal class Program
    {
        public static void RandomIntegers()
        {
            Console.WriteLine("Enter a minimum value: ");
            double minValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter a maximum value: ");
            double maxValue = Convert.ToDouble(Console.ReadLine());
        }

        public static void DiceRoller()
        {
        }

        public static void RandomDecimalNumbers()
        {
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 4 - Random Asignment";


        }
    }
}

/*
Random Numbers Programming Assignment

Create a new Console application that does the following:
Part 1 – Random Integers
Ask the user to enter a minimum and maximum value. Generate and display five random values within
that range (inclusive) on the same line. Look ahead to use a loop if you don’t want to do it manually.
Remember that Console.Write() can be used to print multiple things on one line.
Part 2 – Dice Roller
• Have your program roll two dice. Display each roll and the sum of the rolls.

Part 3 – Random Decimal Numbers
Using the same maximum and minimum values from Part 1, generate and display 3 random decimal
values within that range (inclusive) on the same line.
Things to consider:
• There are several ways you could do this. You can just use NextDouble() and do a bit of
math, or you could generate the decimal and integral part separately.
• Make sure that the range of random numbers is INCLUSIVE. i.e. the maximum value entered
could appear in the range of random numbers generated.
• Test your program several times in a narrow range to ensure that you get all values within the
specified range.

Part 3 Challenges:
• Allow user to specify how many decimals values doubles should be rounded to.
• Ensure that your program doesn’t crash if the user enters a max < min (try If statements).
• Extra challenge: Allow the user to specify the decimal precision when they randomly generate a
double. For example, generate a decimal number between 2.5 and 3.5.
*/
