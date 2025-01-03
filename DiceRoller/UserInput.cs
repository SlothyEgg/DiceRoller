using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class shall process user input. 
 */

namespace DiceRoller
{
    
    internal class UserInput
    {
        private RandomNumbers roller;
        public UserInput() {
            roller = new RandomNumbers();
        }

        //TODO: Handle Multiple Die Rolls.
        public void rollDie(int numberOfDice, int sizeOfDie)
        {
            List<int> diceRolls = roller.GenerateRandomNumbers(numberOfDice, sizeOfDie + 1);
            UserInterface.PrintResults(numberOfDice, sizeOfDie, diceRolls, diceRolls.Sum());
        }
    }
}
