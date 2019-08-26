using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercises
{
    class Program
    {

        static void Main(string[] args)
        {
            //From 1 to 100 COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Press enter to begin L O O P S: The Musical");
            Console.ReadKey();

            for (int counterF = 1; counterF <= 100; counterF++)
            {
                Console.WriteLine(counterF);
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //From 100 to 1 COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------

            int counter = 100;
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //From 1995 to 2017 COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------

            counter = 1995;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter <= 2017);
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //Your Three Favorite Numbers COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------

            int[] favorites = new int[3];
            Console.WriteLine("Howdy! What are your favorite numbers?");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"What's your number {i + 1} favorite number?");
                int.TryParse(Console.ReadLine(), out favorites[i]);
                if (i == 2)
                {
                    Console.WriteLine("Okay, so your favorite numbers are " + favorites[0] + ", " + favorites[1] + ", and " + favorites[2] + ".");
                }
                else if (i == 1)
                {
                    Console.WriteLine("Okay, so your favorite numbers have been " + favorites[0] + ", and " + favorites[1] + "?");
                }
                else if (i == 0)
                {
                    Console.WriteLine("Okay, so your favorite number is " + favorites[0] + "?");
                }
            }

            //From X to Y COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            int userInput, userInput2;
            Console.WriteLine("\nType any two numbers below here!");
            int.TryParse(Console.ReadLine(), out userInput);
            int.TryParse(Console.ReadLine(), out userInput2);
            Console.WriteLine("Heres a list of numbers between those two:\n");

            if (userInput > userInput2)
            {
                for (int counterF = userInput2; counterF <= userInput; counterF++)
                {
                    Console.WriteLine(counterF);
                }
                Console.WriteLine("\nPress enter to continue.\n");
                Console.ReadKey();
            }
            else if (userInput < userInput2)
            {
                for (int counterF = userInput; counterF <= userInput2; counterF++)
                {
                    Console.WriteLine(counterF);
                }
                Console.WriteLine("\nPress enter to continue.\n");
                Console.ReadKey();
            }

            //Largest of Any Number of Numbers COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Now its time for YOU to decide your own fate: how many numbers are you up for typing in in a row?");
            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput < 2)
            {
                Console.WriteLine("Oh come on it needs to be at least 2. I'll just make you do 4 since you wanted to be so funny.");
                userInput = 4;
            }
            Console.WriteLine($"Alright awesome. Now enter {userInput} whole numbers. Remember: you're responsible for this.");
            int[] numbersL = new int[userInput];

            for (int i = 0; i < userInput; i++)
            {
                int.TryParse(Console.ReadLine(), out numbersL[i]);
            }
            Console.WriteLine("Now watch as I take the data you just entered and tell you which one is the largest.");
            int numberToCompare = numbersL[0];

            for (int i = 0; i < userInput; i++)
            {
                if (numberToCompare < numbersL[i])
                {
                    numberToCompare = numbersL[i];
                }               
            }
            Console.WriteLine($"Okay so out of all the numbers you entered, {numberToCompare} is the largest one.");
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //Smallest of Any Number of Numbers COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Now its time for YOU to decid- wait we just did this. I guess the outcome will be different. How many numbers are you up for typing in in a row?");
            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput < 2)
            {
                Console.WriteLine("Oh come on it needs to be at least 2. I'll just make you do 4 since you wanted to be so funny.");
                userInput = 4;
            }
            Console.WriteLine($"Alright awesome. Now enter {userInput} whole numbers. Remember: you're responsible for this.");
            int[] numbersS = new int[userInput];

            for (int i = 0; i < userInput; i++)
            {
                int.TryParse(Console.ReadLine(), out numbersS[i]);
            }
            Console.WriteLine("Now I'll instantly take the data you just entered and tell you which one is the smallest.");
            numberToCompare = numbersS[0];

            for (int i = 0; i < userInput; i++)
            {
                if (numberToCompare > numbersS[i])
                {
                    numberToCompare = numbersS[i];
                }
            }
            Console.WriteLine($"Right- so out of all the numbers you submitted, {numberToCompare} is the smallest one.");
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //Even or Odd 2: Electric Boogaloo COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nType any two numbers below here!... Wait we did this too? I guess the end result will be different again.");
            int.TryParse(Console.ReadLine(), out userInput);
            int.TryParse(Console.ReadLine(), out userInput2);
            Console.WriteLine("Even if you entered the first one as being higher than the second, we're gonna flip those.");
            Console.WriteLine("Because now we're going to list whether the range of those numbers are all even or odd:\n");

            if (userInput > userInput2)
            {
                for (int counterF = userInput2; counterF <= userInput; counterF++)
                {
                    if (counterF % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (counterF % 2 == 1)
                    {
                        Console.WriteLine("Odd");
                    }
                }
            }
            else if (userInput < userInput2)
            {
                for (int counterF = userInput; counterF <= userInput2; counterF++)
                {
                    if (counterF % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (counterF % 2 == 1)
                    {
                        Console.WriteLine("Odd");
                    }
                }
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //Fizz Buzz COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nType any two numb-- alright this is getting out of hand. The end result will be different again I swear.");
            int.TryParse(Console.ReadLine(), out userInput);
            int.TryParse(Console.ReadLine(), out userInput2);
            Console.WriteLine("Even if you entered the first one as being higher than the second, we're gonna flip those.");
            Console.WriteLine("Because now we're going to list the range of those numbers... WITH A TWIst I guess its not that exciting:\n");

            if (userInput > userInput2)
            {
                for (int counterF = userInput2; counterF <= userInput; counterF++)
                {
                    if (counterF % 3 == 0 && counterF % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (counterF % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (counterF % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(counterF);
                    }
                }
            }
            else if (userInput < userInput2)
            {
                for (int counterF = userInput; counterF <= userInput2; counterF++)
                {
                    if (counterF % 3 == 0 && counterF % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (counterF % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (counterF % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(counterF);
                    }
                }
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //Grid Generator TODO
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("I need two more numbers from you. I know I've asked at least like 6 times now but I promise THIS ONE is cool.");
            int.TryParse(Console.ReadLine(), out userInput);
            int.TryParse(Console.ReadLine(), out userInput2);

            for (int i = 0; i < userInput; i++)
            {
                for (int j = 0; j < userInput2; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();


            //Higher or Lower COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Random rng = new Random();
            int numberToGuess = rng.Next(1, 10);
            Console.WriteLine("And now, your ultimate test: guess the number. You have 5 tries, I'll give you hints if you're off.\nIt will never be higher than 10 or lower than 1.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Round {i + 1} - Make Your Guess");
                int.TryParse(Console.ReadLine(), out userInput);
                if (userInput > numberToGuess)
                {
                    Console.WriteLine("Nope, your number is too high.");
                }
                else if (userInput < numberToGuess)
                {
                    Console.WriteLine("Nada, your number is too low.");
                }
                else if (userInput == numberToGuess)
                {
                    Console.WriteLine("N- oh wait- you actually got the number right. Congradtion. You done it.");
                    break;
                }
            }
            Console.WriteLine($"The number was {numberToGuess}!");
            Console.WriteLine("\nPress enter to cease.");
            Console.ReadKey();
        }
    }
}
