using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExerciseTV
{
    class Television
    {
        private int currentChannel = 1;
        private int currentVolume = 1;

        /// <summary>
        /// increases the volume by one
        /// </summary>
        public void IncreaseVolume()
        {
            Console.WriteLine();
            Console.WriteLine("Volume Up.");
            currentVolume++;
        }

        /// <summary>
        /// decreases the volume by one
        /// </summary>
        public void DecreaseVolume()
        {
            switch (currentVolume) //Silly little switch to give flavortext for certain volumes (and prevent getting to negative volume)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("Volume already at 0.");
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Volume set to 0. Muting...");
                    currentVolume--;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Volume Down.");
                    currentVolume--;
                    break;

            }
        }

        /// <summary>
        /// returns the current volume
        /// </summary>
        /// <returns></returns>
        public int Volume()
        {
            Console.WriteLine();
            Console.WriteLine("Tv info: Current volume is " + currentVolume + ".");
            return currentVolume;
        }

        /// <summary>
        /// increases the channel num by one
        /// </summary>
        public void IncreaseChannel()
        {
            Console.WriteLine();
            Console.WriteLine("Channel Up.");
            currentChannel++;
        }

        /// <summary>
        /// decreases the channel num by one
        /// </summary>
        public void DecreaseChannel()
        {
            switch (currentChannel) //Silly little switch to give flavortext for certain channels (and prevent getting to negative channels)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Cannot set channel lower than 1.");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Channel Down.");
                    currentChannel--;
                    break;

            }
        }

        /// <summary>
        /// returns the current channel
        /// </summary>
        /// <returns></returns>
        public int Channel()
        {
            Console.WriteLine();
            Console.WriteLine("Tv info: Current channel is " + currentChannel + ".");
            return currentChannel;
        }
    }
}
