using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercisePiggyBank
{
    class Program
    {      
        static void Main(string[] args)
        {
            int userInputBal;
            char userInputMenu;
            bool gameLoop = true;
            DigitalPiggyBank bank = new DigitalPiggyBank();
            Console.WriteLine("PIGGY BANK: Because games let us live our wildest fantasies (like owning money).");
            Console.WriteLine("Controls:");
            Console.WriteLine("\tPress \"A\" to deposit money (takes a whole number amount).");
            Console.WriteLine("\tPress \"S\" to check how much money is in your piggy bank.");
            Console.WriteLine("\tPress \"D\" to withdraw all money.");
            Console.WriteLine("\tPress \"L\" to close.");
            while (gameLoop)
            {
                Console.WriteLine();
                Console.WriteLine("Input a command.");
                userInputMenu = Char.ToLower(Console.ReadKey(true).KeyChar);
                switch (userInputMenu)
                {
                    case 'a':
                        Console.WriteLine("Input a whole number value (ex: 100, 44, 612).");
                        userInputBal = Convert.ToInt32(Console.ReadLine());
                        bank.Deposit(userInputBal);
                        break;
                    case 's':
                        bank.Balance();
                        break;
                    case 'd':
                        bank.Withdraw();
                        break;
                    case 'l':
                        gameLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
                //Console.WriteLine(userInput); //For testing purposes           
            }
        }
    }
}
