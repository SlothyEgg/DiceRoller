using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    
    internal class Interface
    {
        private RandomNumbers roller;
        public Interface() {
            roller = new RandomNumbers();
        }

        //TODO: Handle Multiple Die Rolls.
        public void rollDie(int numberOfDice, int numberOfFaces)
        {
            Console.WriteLine("Rolling die {0}d{1}: {2}", numberOfDice, numberOfFaces, roller.generateRandomNumber(numberOfFaces+1));      
        }
    }
}
