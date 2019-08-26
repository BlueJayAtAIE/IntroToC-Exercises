using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExerciseTV
{
    class Program
    {       
        static void Main(string[] args)
        {
            char userInput = 'h';
            bool powerOn = true;
            Television tv = new Television();

            Console.WriteLine("WELCOME TO TV, the program where you can live the  E N J O Y M E N T  of watching TV without the TV.");
            Console.WriteLine();
            Console.WriteLine("Tv directory:");
            Console.WriteLine("\tPress W to scroll Up a channel.");
            Console.WriteLine("\tPress S to scroll Down a channel.");
            Console.WriteLine("\tPress A to scroll Down the volume.");
            Console.WriteLine("\tPress D to scroll Up the volume.");
            Console.WriteLine("\tPress Q for channel info (current channel number).");
            Console.WriteLine("\tPress E to check your volume settings (current volume number).");
            Console.WriteLine("\tPress P to power off (close window.)");

            while (powerOn)
            {
                userInput = Char.ToLower(Console.ReadKey(true).KeyChar);
                switch (userInput)
                {
                    case 'w':
                        tv.IncreaseChannel();
                        break;
                    case 's':
                        tv.DecreaseChannel();
                        break;
                    case 'a':
                        tv.DecreaseVolume();
                        break;
                    case 'd':
                        tv.IncreaseVolume();
                        break;
                    case 'q':
                        tv.Channel();
                        break;
                    case 'e':
                        tv.Volume();
                        break;
                    case 'p':
                        powerOn = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }
    }
}
