using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
 * This class should handle all elements of generating the random numbers for our die. It should offer public methods to other classes to access to roll 
 * die for the user but it should not interact or be interacted with the user in anyway.
 * 
 * This is strictly a "back-end" class.
 */

namespace DiceRoller
{
    internal class RandomNumbers
    {
        private readonly Random rnd;
        public RandomNumbers()
        {
            rnd = new Random();
        }


        public List<int> GenerateRandomNumbers(int ammount, int upperbound)
        {
            List<int> numbers = new(ammount);
            for (int i = 0; i < ammount; i++) 
            {
                numbers.Add(rnd.Next(1, upperbound));
            }
            return numbers;
        }

    }

    
    }
