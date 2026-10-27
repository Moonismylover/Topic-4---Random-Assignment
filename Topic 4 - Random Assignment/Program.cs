using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int number;

            Random generator = new Random();

            Console.WriteLine("------------------------- Random Integers -------------------------");
            Console.WriteLine();

            Console.Write("Enter a minimum value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter a maximum value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine(generator.Next(minValue, maxValue + 1));
            }

            /*
            
            Summary: 

            1) Requested user input. Stored the input into variables using Convert.ToInt32().
            2) Used a for() loop to generate 5 values between the two inputted values.
                a) index = 0 means it starts at 0.
                b) index < 5 means only give 5 ouputs
                c) index++ means go to the next value/round.

            */
        }

        public static void DiceRoller()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int diceOne, diceTwo, sum;

            Random generator = new Random();

            Console.WriteLine("------------------------- Dice Roller -------------------------");
            Console.WriteLine();

            string[] one =
            {
                @"
                ┌─────────┐
                │         │
                │    ●    │
                │         │
                └─────────┘
                "
            };

            string[] two =
            {
                @"
                ┌─────────┐
                │  ●      │
                │         │
                │      ●  │
                └─────────┘
                "
            };

            string[] three =
            {
                @"
                ┌─────────┐
                │  ●      │
                │    ●    │
                │      ●  │
                └─────────┘
                "
            };

            string[] four =
            {
                @"
                ┌─────────┐
                │  ●   ●  │
                │         │
                │  ●   ●  │
                └─────────┘
                "
            };

            string[] five =
            {
                @"
                ┌─────────┐
                │  ●   ●  │
                │    ●    │
                │  ●   ●  │
                └─────────┘
                "
            };

            string[] six =
            {
                @"
                ┌─────────┐
                │  ●   ●  │
                │  ●   ●  │
                │  ●   ●  │
                └─────────┘
                "
            };

            Console.WriteLine("Welcome to the DICE ROLLER!");
            Console.Write("Would you like to roll (yes/no)?");
            Console.ReadLine().ToLower();

            if (Console.ReadLine() == "yes")
            {
                diceOne = generator.Next(1, 7);
                diceTwo = generator.Next(1, 7);

                if (diceOne == 1)
                {

                }
                else if (dice)
            }
            else
            {
                Console.WriteLine("Alrighty!!! Have a good day then!");
                Console.ReadLine();
            }
        }

        public static void RandomDecimalNumbers()
        {
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 4 - Random Asignment";

            RandomIntegers();




        }
    }
}

/*
Random Numbers Programming Assignment


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
