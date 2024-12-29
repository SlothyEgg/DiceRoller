using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class RandomNumbers
    {
        private Random rnd;
        public RandomNumbers()
        {
            rnd = new Random();
        }

        public int generateRandomNumber(int upperbound)
        {
            return rnd.Next(0, upperbound);
        }

    }

    
    }
