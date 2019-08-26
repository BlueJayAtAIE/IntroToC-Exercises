using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            int userInputMenu = 0;
            while (userInputMenu != 9)
            {
                Console.Clear();
                Console.WriteLine("Enter a number (1-7) fo view a certain exercise.\n\t1. Countdown\n\t2. Input Reverse\n\t3. Largest and Smallest");
                Console.WriteLine("\t4. Number Grid\n\t5. Grid Statistics\n\t6. Monster Attack\n\t7. Dragon Simulator 2019");
                Console.WriteLine("Enter \"9\" to exit.");
                int.TryParse(Console.ReadLine(), out userInputMenu);
                Console.WriteLine();
                switch (userInputMenu)
                {
                    case 1:
                        Countdown();
                        break;
                    case 2:
                        Reverse();
                        break;
                    case 3:
                        LargestSmallest();
                        break;
                    case 4:
                        Grid();
                        break;
                    case 5:
                        GridStats();
                        break;
                    case 6:
                        MonsterSim();
                        break;
                    case 7:
                        DragonSim();
                        break;
                    default:
                        break;
                }
            }
        }

        static void Countdown()
        {
            //3. ------------------------------------------------------ COMPLETE
            int[] data = new int[10];
            for (int i = 9; i >= 0; i--)
            {
                data[i] = i + 1;
                Console.WriteLine(data[i]);
            }
            Console.WriteLine("This is a countdown from 10 to 1. Enjoy.");
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();
        }

        static void Reverse()
        {
            //4. ------------------------------------------------------ COMPLETE
            int[] userValues1 = new int[5];
            Console.WriteLine("Hey you- give me some numbers. Like five of 'em.");
            for (int i = 0; i < 5; i++)
            {
                int.TryParse(Console.ReadLine(), out userValues1[i]);
                Console.WriteLine("Alright, keep 'em comin'.");
            }

            Console.WriteLine("...WAIT. Wait STOP. Okay heres those numbers agin:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(userValues1[i]);
            }
            Console.WriteLine("Thanks for sharing some numbers.");
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();
        }

        static void LargestSmallest()
        {
            //5. ------------------------------------------------------ COMPLETE
            Console.WriteLine("Hey look- It's an old favorite. I need you to enter 10 whole numbers, and I'll tell you which one is the largest, and which one is the smallest.");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            //How this works:
            //numberToCompare is set to the first value in numbers[].
            //The "for" loop below goes through and compares numberToCompare to numbers[i], and if numberToCompare is less, numberToCompare sets itself to numbers[i]'s value.
            //The result is then printed after the end of the "for" loop.
            int numberToCompare = numbers[0];
            for (int i = 0; i < 10; i++)
            {
                if (numberToCompare < numbers[i])
                {
                    numberToCompare = numbers[i];
                }
            }
            Console.WriteLine($"From the submitted pool of numbers, {numberToCompare} is the largest one.");

            //This works the exact same as above, but with ">" rather than "<", so numberToCompare will change itself when it is greater than numbers[i].
            numberToCompare = numbers[0];
            for (int i = 0; i < 10; i++)
            {
                if (numberToCompare > numbers[i])
                {
                    numberToCompare = numbers[i];
                }
            }
            Console.WriteLine($"Aaaand furthermore, out of all the numbers you entered, {numberToCompare} is the smallest one.");

            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();
        }

        static void Grid()
        {
            //6. ------------------------------------------------------ ...complete
            //I don't like this solution. It feels cheesy.
            int[,] grid = new int[3, 3];
            int gridPopulator = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = gridPopulator++;
                    Console.Write(grid[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();
        }

        static void GridStats()
        {
            //7. ------------------------------------------------------ COMPLETE
            int[,] days = new int[29, 5];
            Console.WriteLine("Array as normal:"); //Populating the table.
            for (int i = 0; i < 29; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    days[i, j] = rng.Next(2);
                    Console.Write(days[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //How this works:
            //There are 29 rows of 5 columns.
            //The innermost "for" will loop through 5 times, adding everything in that row.
            //The outtermost "for" will repeat this for all 29 rows, and after the first loop of adding everything together, it will display the result and set back to 0.
            Console.WriteLine("Sum of rows:");
            int sumRows = 0;
            for (int i = 0; i < 29; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sumRows += days[i, j];
                }
                Console.WriteLine(sumRows);
                sumRows = 0;
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();

            //Effectively, this works the same as above, but with some values flipped, as now we're effectively looking at it as 5 rows of 29 columns (internally).
            //Another signifigant note is the use of "Write" instead of "WriteLine"- this is for display purposes, to more easily view them relative to the normal array.
            Console.WriteLine("Sum of columns:");
            int sumCols = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    sumCols += days[j, i];
                }
                Console.Write(sumCols + "\t");
                sumCols = 0;
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();
        }

        static void MonsterSim()
        {
            //8. ------------------------------------------------------ COMPLETE
            int[] playerCharacters = new int[5] { 100, 100, 100, 100, 100 };
            int userInput;
            Console.WriteLine("You are a villian. Before you stand 5 brave heroes. In just 5 attacks try to deal as much damage as possible.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Which hero will you attack? (Enter a number from 0 to 4)");
                int.TryParse(Console.ReadLine(), out userInput);
                if (userInput > 4) //This is to prevent an error that results from entering a number too high and sending the array out of range.
                {
                    userInput = 4;
                }

                playerCharacters[userInput] -= rng.Next(35, 50);

                if (playerCharacters[userInput] < 0) //This is here to clamp the value to 0, preventing negative health. Also informs the player to make another choice.
                {
                    Console.WriteLine($"Hero {userInput + 1} has been defeated. Choose another option.");
                    playerCharacters[userInput] = 0;
                    i--;
                }
            }

            Console.WriteLine("BATTLE RESULTS:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Hero {i + 1}: {playerCharacters[i]} HP Remaining.");
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();
        }

        static void DragonSim()
        {
            //9. ------------------------------------------------------ COMPLETE
            int[,] dragonTable = new int[3, 7];
            string[] dragonNames = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter a name for Dragon number {i + 1}:");
                dragonNames[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"\nEnter the amount of food (as a whole number) that {dragonNames[i]} has eaten on Day {j + 1} in kilos:");
                    int.TryParse(Console.ReadLine(), out dragonTable[i, j]);
                }
            }
            Console.WriteLine("\nSTATISTICS\n==========");

            //Sum of All Food (Extra)
            //How it works:
            //Similar to the concept from exercise 7, but it adds EVERYTHING in the table together. To get the average, we simply divide by 7, then by 3.
            int sumDragon = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    sumDragon += dragonTable[i, j];
                }
            }
            Console.WriteLine($"Sum of food eaten Overall: {sumDragon} kilos");

            //Average of All
            Console.WriteLine($"Average of Food eaten Overall: {(sumDragon / 7) / 3} kilos");

            //Average By Dragon
            //How it works:
            //Almost an exact copy of the sum of rows in problem 7, but with the addition of the WriteLine for the Average Food eaten.
            Console.WriteLine("\n\nAverage Food eaten Per Dragon\n");
            sumDragon = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    sumDragon += dragonTable[i, j];
                }
                Console.WriteLine($"Sum of Food eaten by {dragonNames[i]}: {sumDragon}");
                Console.WriteLine($"Average of Food eaten by {dragonNames[i]}: {sumDragon / 7}\n");
                sumDragon = 0;
            }

            //Most Food Eaten
            //How it works:
            //Similar to how number 5 works, dragonCompare[] will store the smallest number from each row of the table.
            //How it does this is by: at the start of the outtermost "for" loop it sets itself to the first value in the row of dragonTable[] its currently evaluating.
            //It will then go through the values, and change itself if it finds a larger value.
            int[] dragonCompareL = new int[3];
            for (int i = 0; i < 3; i++)
            {
                dragonCompareL[i] = dragonTable[i, 0];
                for (int j = 0; j < 7; j++)
                {
                    if (dragonCompareL[i] < dragonTable[i, j])
                    {
                        dragonCompareL[i] = dragonTable[i, j];
                    }
                    //Console.WriteLine(dragonCompareL[i]); //For testing
                }
            }

            //Finally, down here the series of if/elses will compare all the values of dragonCompare[], and print a WriteLine accordingly.        
            if (dragonCompareL[0] > dragonCompareL[1])
            {
                if (dragonCompareL[0] > dragonCompareL[2])
                {
                    Console.WriteLine($"{dragonNames[0]} ate the most in one day, at {dragonCompareL[0]} kilos.");
                }
                else
                {
                    Console.WriteLine($"{dragonNames[2]} ate the most in one day, at {dragonCompareL[2]} kilos.");
                }
            }
            else
            {
                if (dragonCompareL[1] > dragonCompareL[2])
                {
                    Console.WriteLine($"{dragonNames[1]} ate the most in one day, at {dragonCompareL[1]} kilos.");
                }
                else
                {
                    Console.WriteLine($"{dragonNames[2]} ate the most in one day, at {dragonCompareL[2]} kilos.");
                }
            }

            //Least Food Eaten
            //How it works:
            //This largely works the exact same as above, however unfortunately it couldn't be reused since the signs needed to be flipped.
            int[] dragonCompareS = new int[3];
            for (int i = 0; i < 3; i++)
            {
                dragonCompareS[i] = dragonTable[i, 0];
                for (int j = 0; j < 7; j++)
                {
                    if (dragonCompareS[i] > dragonTable[i, j])
                    {
                        dragonCompareS[i] = dragonTable[i, j];
                    }
                    //Console.WriteLine(dragonCompareS[i]); //For testing
                }
            }

            if (dragonCompareS[0] < dragonCompareS[1])
            {
                if (dragonCompareS[0] < dragonCompareS[2])
                {
                    Console.WriteLine($"{dragonNames[0]} ate the least in one day, at only {dragonCompareS[0]} kilos.");
                }
                else
                {
                    Console.WriteLine($"{dragonNames[2]} ate the least in one day, at only {dragonCompareS[2]} kilos.");
                }
            }
            else
            {
                if (dragonCompareS[1] < dragonCompareS[2])
                {
                    Console.WriteLine($"{dragonNames[1]} ate the least in one day, at only {dragonCompareS[1]} kilos.");
                }
                else
                {
                    Console.WriteLine($"{dragonNames[2]} ate the least in one day, at only {dragonCompareS[2]} kilos.");
                }
            }
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadKey();
        }
    }
}
