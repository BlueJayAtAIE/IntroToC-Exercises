using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number Judging COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("TRAIL 1: NUMBERS");
            Console.WriteLine("================");
            int userInputInt;
            Console.WriteLine("Enter a number between 1 and 100.");
            int.TryParse(Console.ReadLine(), out userInputInt);

            if (userInputInt == 50)
            {
                Console.WriteLine("Exactly 50? A very balanced number.");
            }
            else if (userInputInt > 50)
            {
                Console.WriteLine(userInputInt + "? Seems like a number on the larger side.");
            }
            else if (userInputInt < 50)
            {
                Console.WriteLine(userInputInt + "? Seems like a number on the smaller side.");
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();

            //Age Gate COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("TRIAL 2: AGE");
            Console.WriteLine("============");
            Console.WriteLine("Please enter your age.");
            int.TryParse(Console.ReadLine(), out userInputInt);

            if (userInputInt < 18)
            {
                Console.WriteLine("Sorry buddy, you're a minor to I can't let you play the rest of the game.");
                Console.WriteLine("Press enter to close this window.");
                Console.ReadKey();
                Console.WriteLine("Just kidding you're good to go.");
            }
            else if (userInputInt >= 65)
            {
                Console.WriteLine("You're eligible for retirement benefits. I don't have a funny joke for this one.");
            }
            else if (userInputInt >= 50)
            {
                Console.WriteLine("You're old enough to join the AARP. (This message brought to you by the AARP. AARP, Because You're Old (tm))");
            }
            else if (userInputInt >= 18)
            {
                Console.WriteLine("You're an adult now. You have to do things like taxes, and pretending to like your coworkers. Anyways,");
            }
            Console.WriteLine("And now the real trials can begin...");
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();

            //The Smallest of Three Numbers COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("TRIAL 3: NUMBERS THREE");
            Console.WriteLine("======================");
            Console.WriteLine("It's not that we skipped \"NUMBERS TWO\", its that I need from thee numbers three.");
            int userInputInt2, userInputInt3;
            int.TryParse(Console.ReadLine(), out userInputInt);
            int.TryParse(Console.ReadLine(), out userInputInt2);
            int.TryParse(Console.ReadLine(), out userInputInt3);

            if (userInputInt < userInputInt2)
            {
                if (userInputInt < userInputInt3)
                {
                    Console.WriteLine(userInputInt + " is the smallest number.");
                }
                else
                {
                    Console.WriteLine(userInputInt3 + " is the smallest number.");
                }
            }
            else
            {
                if (userInputInt2 < userInputInt3)
                {
                    Console.WriteLine(userInputInt2 + " is the smallest number.");
                }
                else
                {
                    Console.WriteLine(userInputInt3 + " is the smallest number.");
                }
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();

            //Even or Odd COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("TRIAL 4: EVEN OR ODD");
            Console.WriteLine("====================");
            Console.WriteLine("Now give me a whole number, I'll tell you if its even or odd. That's it. That's the game.");
            int.TryParse(Console.ReadLine(), out userInputInt);

            if (userInputInt % 2 == 0)
            {
                Console.WriteLine("The number " + userInputInt + " is even!");
            }
            else if (userInputInt % 2 == 1)
            {
                Console.WriteLine("The number " + userInputInt + " is odd!");
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();

            //Clamp the Number COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("TRIAL 5: NUMBERS THREE (2)");
            Console.WriteLine("==========================");
            Console.WriteLine("Okay it's called \"NUMBERS THREE (2)\" because it's the third number related game BUT that title was already taken. So yeah.");
            Console.WriteLine("Give me a number between 15 and 30.");
            int.TryParse(Console.ReadLine(), out userInputInt);

            if (userInputInt > 30)
            {
                Console.WriteLine(userInputInt + " is too high buddy. I'm gonna put you down for 30 instead.");
                userInputInt = 30;
            }
            else if (userInputInt < 15)
            {
                Console.WriteLine(userInputInt + " is too low buddy. I'm gonna put you down for 15 instead.");
                userInputInt = 15;
            }
            Console.WriteLine("So in the end you chose the number " + userInputInt);
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();

            //Complete the Following (4/4 COMPLETE)
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("TRIAL 6: CHOICES");
            Console.WriteLine("================");
            // Field:       Thai Spiciness Rating
            // Constraints: Any number from 0 to 5, inclusive of both ends.
            int thaiSpiceRating;
            Console.WriteLine("(1/4) On a scale from 1 to 5, how spicy should your food be?");
            int.TryParse(Console.ReadLine(), out thaiSpiceRating);

            if (thaiSpiceRating > 5)
            {
                Console.WriteLine("Number too high. Defaulting to 5.");
                thaiSpiceRating = 5;
            }
            else if (thaiSpiceRating < 0)
            {
                Console.WriteLine("Number too low. Defaulting to 0.");
                thaiSpiceRating = 0;
            }
            Console.WriteLine("You ordered with a spiciness rating of " + thaiSpiceRating.ToString());
            Console.WriteLine();


            // Field:       Purchase Order for Cookies
            // Constraints: Must be ordered in multiples of 23. Only whole numbers.
            //              Round down to the nearest multiple if not a multiple of 23.
            //              If nearest multiple is zero, provide an error message.
            int cookieOrder;
            Console.WriteLine("(2/4) How many cookies do you want to order? Orders only work in multiples of 23.");
            int.TryParse(Console.ReadLine(), out cookieOrder);

            if (cookieOrder % 23 != 0)
            {
                Console.WriteLine("Cookie order not a multiple of 23. Defaulting to 23.");
                cookieOrder = 23;
            }
            Console.WriteLine("You ordered a total of " + cookieOrder + " cookies.");
            Console.WriteLine();

            // Field:       Purchase Order for Sketchbooks (3pk)
            // Constraints: Must order at least 9 sketchbooks total.
            //              The total may not exceed 30 sketchbooks ordered.
            //              If the total number of sketchbooks ordered does not meet
            //              the minimum order count or exceeds the maximum order count,
            //              provide an error message.
            int sketchBookOrder;
            Console.WriteLine("(3/4) Order any amount of 3-Pack Sketchbooks. You must purchase a TOTAL of 9 individual sketchbooks at the least, or 30 at most.");
            int.TryParse(Console.ReadLine(), out sketchBookOrder);

            if (sketchBookOrder < 3)
            {
                Console.WriteLine("Total too low. Defaulting to 9 (3 packs).");
                sketchBookOrder = 3;
            }
            else if (sketchBookOrder > 10)
            {
                Console.WriteLine("Total too high. Defaulting to 30 (10 packs).");
                sketchBookOrder = 10;
            }
            Console.WriteLine("You ordered " + sketchBookOrder + " packs of sketchbooks, for a total of " + (sketchBookOrder * 3));
            Console.WriteLine();

            // Field:       Enable Motion Blur
            // Constraints: Must be a 'y' or 'n' value.
            //              Provide an error message if any other value.
            char motionToggle;
            Console.WriteLine("(4/4) Enable Motion Blur? Type \"Y\" for yes, \"N\" for no.");
            motionToggle = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (motionToggle == 'y')
            {
                Console.WriteLine("Motion Blur has been toggled on.");
            }
            else if (motionToggle == 'n')
            {
                Console.WriteLine("Motion Blur has been toggled off.");
            }
            else
            {
                Console.WriteLine("Not a valid key. Turning on Motion Blur anyways :^)");
                motionToggle = 'y';
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();

            //Four Function Disposable Calculator COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("TRAIL 7: MATH");
            Console.WriteLine("=============");
            Console.WriteLine("And now you get a break from the tedium. Just kidding.");
            Console.WriteLine("Input two numbers:");
            int.TryParse(Console.ReadLine(), out userInputInt);
            int.TryParse(Console.ReadLine(), out userInputInt2);
            Console.WriteLine("Now input what you want to do with these numbers.\n\"a\" for addition, \"s\" for subtraction, \"m\" for multiplication, and \"d\" for division.");
            char userInputChar;
            userInputChar = Char.ToLower(Console.ReadKey(true).KeyChar); //I'm sorry but I'm so tired of using ifs... I have to use a switch at least once in here or I'll go nuts.

            switch (userInputChar)
            {
                case 'a':
                    Console.WriteLine((userInputInt + userInputInt2) + " is your final solution.");
                    break;
                case 's':
                    Console.WriteLine((userInputInt - userInputInt2) + " is your final solution.");
                    break;
                case 'm':
                    Console.WriteLine((userInputInt * userInputInt2) + " is your final solution.");
                    break;
                case 'd':
                    if (userInputInt > userInputInt2)
                    {
                        Console.WriteLine((userInputInt / userInputInt2) + " is your final solution.");
                    }
                    else
                    {
                        Console.WriteLine("Since you did a larger number first we're gonna flip the numbers turnways to do this math.");
                        Console.WriteLine((userInputInt2 + userInputInt) + " is your final solution.");
                    }
                    break;
                default:
                    Console.WriteLine("That's not a valid command. I'm just gonna boot ya. BYE.");
                    break;
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();

            //A Battle of Prehistoric Proportions COMPLETE
            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("TRIAL 8: FINAL BOSS"); 
            Console.WriteLine("===================");
            Console.WriteLine("Okay so now you have to fight a baby dinosaur. Please don't question what's going on, just answer honestly.");
            string userInputStr;
            int playerPoint = 0;
            int dinoPoint = 0;

            Console.WriteLine("On a scale from 1 to 10, how strong are you?"); //Q1
            userInputInt = Int32.Parse(Console.ReadLine());
            if (userInputInt > 10 || userInputInt < 1)
            {
                Console.WriteLine("Thats number is outside the bounds so I'm going to have to put you down as a 1.");
                userInputInt = 1;
            }

            if (userInputInt > 4)
            {
                Console.WriteLine("PLAYER WINS ROUND");
                playerPoint++;
            }
            else if (userInputInt == 4)
            {
                Console.WriteLine("TIE ROUND");
            }
            else if (userInputInt < 4)
            {
                Console.WriteLine("DINO WINS ROUND");
                dinoPoint++;
            }
            Console.WriteLine();

            Console.WriteLine("Now its time for a game known throughout the universe. Type \"rock\", \"paper\", or \"scissors\". All lowercase if possible."); //Q2
            userInputStr = Console.ReadLine();
            if (userInputStr == "rock")
            {
                Console.WriteLine("Dino chooses Paper!");
                Console.WriteLine("DINO WINS ROUND");
                dinoPoint++;
            }
            else if (userInputStr == "paper")
            {
                Console.WriteLine("Dino chooses Paper!");
                Console.WriteLine("TIE ROUND");
            }
            else if (userInputStr == "scissors")
            {
                Console.WriteLine("Dino chooses Paper!");
                Console.WriteLine("PLAYER WINS ROUND");
                playerPoint++;
            }
            else
            {
                Console.WriteLine("I don't understand the command \"" + userInputStr + "\" and the dino doesn't either.");
                Console.WriteLine("ROUND DEFAULT");
            }
            Console.WriteLine();

            Console.WriteLine("Time for another numerical question- how many battles have you fought?"); //Q3
            userInputInt = Int32.Parse(Console.ReadLine());
            if (userInputInt > 2)
            {
                Console.WriteLine("Having more experience than the dino, PLAYER WINS ROUND.");
                playerPoint++;
            }
            else
            {
                Console.WriteLine("Having less experience than a literal baby, DINO WINS ROUND");
                dinoPoint++;
            }
            Console.WriteLine();

            Console.WriteLine("Next, a personal question: have you gotten enough sleep last night? Answer \"y\" for yes or \"n\" for no."); //Q4
            userInputChar = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (userInputChar == 'y')
            {
                Console.WriteLine("At first it seems as if you and the dino are tied for sleep, but it turns out you had 4 more minytes of sleep.");
                Console.WriteLine("PLAYER TECHNICALLY WINS ROUND");
                playerPoint++;
            }
            else
            {
                Console.WriteLine("At least you were honest.");
                Console.WriteLine("DINO WINS ROUND");
                dinoPoint++;
            }
            Console.WriteLine();

            Console.WriteLine("And now for the t-t-t-tally. Go ahead and press enter when you're ready."); //Score Tally 
            Console.ReadKey();
            if (playerPoint > dinoPoint)
            {
                Console.WriteLine("YOU'VE WON");
            }
            else if (dinoPoint > playerPoint)
            {
                Console.WriteLine("YOU'VE LOST");
            }
            else if (dinoPoint == playerPoint)
            {
                Console.WriteLine("Oh? look's like its time for.... S U D D E N  D E A T H"); //SUDDEN DEATH ROUND
                Console.WriteLine("Quick, what's your daily Vitamin C intake? Answer with a number.");
                userInputInt = Int32.Parse(Console.ReadLine());
                if (userInputChar > 75)
                {
                    Console.WriteLine("YOU'VE WON");
                }
                else
                {
                    Console.WriteLine("YOU'VE LOST");
                }
            }
            Console.WriteLine("(Press enter to continue).");
            Console.ReadKey();

            //----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(); //Conclusion
            Console.WriteLine("Thanks for playing through these random questi- I mean TRIALS.");
            Console.WriteLine("Theres not really any more point to this.");
            Console.WriteLine("This window will self destruct in one enter press.");
            Console.ReadKey();
        }
    }
}
