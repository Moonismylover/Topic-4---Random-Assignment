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
            int minValue, maxValue, answer;

            Random generator = new Random();

            Console.WriteLine("------------------------- Random Integers -------------------------");
            Console.WriteLine();

            Console.Write("Enter a minimum value: ");

            while (!Int32.TryParse(Console.ReadLine(), out minValue))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Enter a minimum value: ");
            }

            Console.WriteLine();

            Console.Write("Enter a maximum value: ");

            while (!Int32.TryParse(Console.ReadLine(), out maxValue) || maxValue < minValue)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Enter a maximum value: ");
            }

            Console.WriteLine();

            for (int index = 1; index < 6; index++)
            {
                answer = generator.Next(minValue, maxValue + 1);
                Console.WriteLine($"Answer: {answer}");
            }

            Console.WriteLine();

            /*
            
            Summary: 

            1) Requested user input. Stored the input into variables using Convert.ToInt32() --> Changed to while loop.
            2) Used a for() loop to generate 5 values between the two inputted values.
                a) index = 1 means it starts at 1.
                b) index < 6 means only give 5 ouputs.
                c) index++ means go to the next value/round.

            */
        }

        public static void DiceRoller()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int diceOne, diceTwo, sum;
            string response;

            Random generator = new Random();

            Console.WriteLine("------------------------- Dice Roller -------------------------");
            Console.WriteLine();

            string[] dice =
            {
                @"
                ┌─────────┐
                │         │
                │    ●    │
                │         │
                └─────────┘
                ", 

                @"
                ┌─────────┐
                │  ●      │
                │         │
                │      ●  │
                └─────────┘
                ", 

                @"
                ┌─────────┐
                │  ●      │
                │    ●    │
                │      ●  │
                └─────────┘
                ", 

                @"
                ┌─────────┐
                │  ●   ●  │
                │         │
                │  ●   ●  │
                └─────────┘
                ",

                @"
                ┌─────────┐
                │  ●   ●  │
                │    ●    │
                │  ●   ●  │
                └─────────┘
                ",
                
                @"
                ┌─────────┐
                │  ●   ●  │
                │  ●   ●  │
                │  ●   ●  │
                └─────────┘
                "
            };

            Console.WriteLine("Welcome to the DICE ROLLER!");
            Console.Write("Would you like to roll (yes/no): ");
            response = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (response == "yes")
            {
                diceOne = generator.Next(1, 7);
                diceTwo = generator.Next(1, 7);
                sum = diceOne + diceTwo;

                Console.WriteLine($"Congrats! You rolled a {diceOne} and a {diceTwo}! The sum of which is {sum}!");

                if (sum == 2)
                {
                    Console.WriteLine(dice[1]);
                }
                else if (sum == 3)
                {
                    Console.WriteLine(dice[2]);
                }
                else if (sum == 4)
                {
                    Console.WriteLine(dice[3]);
                }
                else if (sum == 5)
                {
                    Console.WriteLine(dice[4]);
                }
                else if (sum == 6)
                {
                    Console.WriteLine(dice[5]);
                }
                else if (sum == 7)
                {
                    if (diceOne == 1 && diceTwo == 2 || diceOne == 2 && diceTwo == 1)
                    {
                        Console.WriteLine(dice[0]);
                        Console.WriteLine(dice[1]);
                    }
                    else if (diceOne == 2 && diceTwo == 5 || diceOne == 5 && diceTwo == 2)
                    {
                        Console.WriteLine(dice[1]);
                        Console.WriteLine(dice[4]);
                    }
                    else if (diceOne == 3 && diceTwo == 4 || diceOne == 4 && diceTwo == 3)
                    {
                        Console.WriteLine(dice[2]);
                        Console.WriteLine(dice[3]);
                    }
                    else if (diceOne == 1 && diceTwo == 6 || diceOne == 6 && diceTwo == 2)
                    {
                        Console.WriteLine(dice[0]);
                        Console.WriteLine(dice[5]);
                    }
                }
                else if (sum == 8)
                {
                    if (diceOne == 2 && diceTwo == 6 || diceOne == 6 && diceTwo == 2)
                    {
                        Console.WriteLine(dice[1]);
                        Console.WriteLine(dice[5]);
                    }
                    else if (diceOne == 4 && diceTwo == 4)
                    {
                        Console.WriteLine(dice[3]);
                        Console.WriteLine(dice[3]);
                    }
                    else if (diceOne == 5 && diceTwo == 3 || diceOne == 3 && diceTwo == 5)
                    {
                        Console.WriteLine(dice[4]);
                        Console.WriteLine(dice[2]);
                    }
                }
                else if (sum == 9)
                {
                    if (diceOne == 4 && diceTwo == 5 || diceOne == 5 && diceTwo == 4)
                    {
                        Console.WriteLine(dice[3]);
                        Console.WriteLine(dice[4]);
                    }
                    else if (diceOne == 6 && diceTwo == 3 || diceOne == 3 && diceTwo == 6)
                    {
                        Console.WriteLine(dice[5]);
                        Console.WriteLine(dice[2]);
                    }
                }
                else if (sum == 10)
                {
                    if (diceOne == 5 && diceTwo == 2 || diceOne == 2 && diceTwo == 5)
                    {
                        Console.WriteLine(dice[4]);
                        Console.WriteLine(dice[1]);
                    }
                    else if (diceOne == 6 && diceTwo == 4 || diceOne == 4 && diceTwo == 6)
                    {
                        Console.WriteLine(dice[5]);
                        Console.WriteLine(dice[3]);
                    }
                }
                else if (sum == 11)
                {
                    if (diceOne == 6 && diceTwo == 5 || diceOne == 5 && diceTwo == 6)
                    {
                        Console.WriteLine(dice[5]);
                        Console.WriteLine(dice[4]);
                    }
                }
                else if (sum == 12)
                {
                    if (diceOne == 6 && diceTwo == 6)
                    {
                        Console.WriteLine(dice[5]);
                        Console.WriteLine(dice[5]); 
                    }
                }
            }
            else
            {
                Console.WriteLine("Alrighty!!! Have a good day then!");
                Console.ReadLine();
            }

            Console.WriteLine();

            /*
        
            Summary:

            1) Requested user input to play?
            2) Arranged dice art into a array
            3) If response was "yes," then diceOne and diceTwo were rolled and added.
            4) The art of a specific sum was called upon to display.
                a) Used "and" + "or" statements to balance both probabilites.
                b) arrary[0] is the first one.
            
            */
        }

        public static void RandomDecimalNumbers()
        {
            decimal minValue, maxValue, answer, finalAns;
            int decPlace;

            Random generator = new Random();

            Console.WriteLine("------------------------- Random Decimal Number -------------------------");
            Console.WriteLine();

            Console.Write("Enter a minimum value (decimal): ");

            while (!Decimal.TryParse(Console.ReadLine(), out minValue))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Enter a minimum value (decimal): ");
            }

            Console.WriteLine();

            Console.Write("Enter a maximum value (decimal): ");

            while (!Decimal.TryParse(Console.ReadLine(), out maxValue) || maxValue < minValue)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Enter a maximum value (decimal): ");
            }

            Console.WriteLine();

            Console.Write("Enter the number of decimal places preferred: ");

            while (!Int32.TryParse(Console.ReadLine(), out decPlace))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!!! Please try again!");
                Console.Write("Enter the number of decimal places preferred: ");
            }

            for (decimal index = 1; index < 4; index++)
            {
                answer = (decimal)(((generator.NextDouble() * (double)(maxValue - minValue)) + (double)(minValue)));
                finalAns = Math.Round(answer, decPlace);
                Console.WriteLine($"Answer: {finalAns}");
            }

            /*
            
            Summary: 

            1) Requested user input. Stored the input into variables using Convert.ToDecimal() --> Changed to while loop.
            2) Used a for() loop to generate 3 values between the two inputted values.
                a) index = 1 means it starts at 1.
                b) index < 4 means only give 3 ouputs
                c) index++ means go to the next value/round.
            3) Math: Find the difference b/w min and max and make it double. Then multiply by random value generated,
                     following which add in the min in double form. Then convert double back to decimal.
            4) Option to choose number of decimal places using Math.Round(decimal, int).0

            */
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 4 - Random Asignment";

            RandomIntegers();

            DiceRoller();

            RandomDecimalNumbers();
        }
    }
}

