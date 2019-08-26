using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercisePiggyBank
{
    // Manages a digital money store that can only be deposited.
    // The balance may not be withdrawn without retrieving the full value.
    class DigitalPiggyBank
    {
        // Maintains the current balance of the piggy bank.
        private float currentBalance;
        
        /// <summary>
        /// Add funds to the value of the current balance.
        /// </summary>
        /// <param name="net"></param>
        public void Deposit(float net)
        {
            currentBalance += net;
            Console.WriteLine("You added " + net + " of your favorite currency to your bank.");
        }
 
        /// <summary>
        /// Returns and clears the total current balance. Clearified: piggybank is made empty.
        /// </summary>
        /// <returns></returns>
        public float Withdraw()
        {
            Console.WriteLine("You took all the money out of your bank. It ended up being " + currentBalance);
            currentBalance = 0;
            return currentBalance;
        }

        /// <summary>
        /// Returns the current balance of the piggybank.
        /// </summary>
        /// <returns></returns>
        public float Balance()
        {
            Console.WriteLine("Your current balance is " + currentBalance + " monies.");
            return currentBalance;
        }
    };
}
