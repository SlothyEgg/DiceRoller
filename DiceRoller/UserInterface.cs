using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class here is to provide simply a Graphical user interface for the user to interact with the program through. It should merely be responsible for
 * navigation and displaying the interface as well as any output from the program.
 * 
 * This will start as a skeleton of an interface in the command line while i work on the functionality of the program and should be built out into a proper
 * GUI later.
 */

namespace DiceRoller
{
    internal class UserInterface
    {
        private readonly UserInput userInput;
        public UserInterface()
        {
            this.userInput = new UserInput();
            AskForInput(); 

        }

        public void AskForInput()
        {
            while (true)
            {
                int numberOfDie;
                while (true)
                {
                    Console.WriteLine("Hello, please input the number of dice that you would like to roll, or EXIT to leave.");
                    String input = Console.ReadLine()!;
                    if (input == "EXIT")
                    {
                        return;
                    }
                    bool ValidInput = int.TryParse(input, out numberOfDie);
                    if (ValidInput && numberOfDie > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a positive integer that is <= " + Int32.MaxValue);
                    }
                }
                userInput.rollDie(numberOfDie, 20);
            }
        }

        public static void PrintResults(int numberOfDice, int sizeOfDie,List<int> rolls,int result)
        { 

            Console.Write("Rolling {0}d{1}: ", numberOfDice, sizeOfDie);
            for (int i = 0; i < rolls.Count; i++) 
            {
                if (i > 0)
                {
                    Console.Write(" + ");
                }
                Console.Write(" [" + rolls[i] + "] ");
            }

            Console.Write(" = " + +result+ "\n");
        }
    }
}
