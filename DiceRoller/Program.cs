// See https://aka.ms/new-console-template for more information
using DiceRoller;

public class Program
{   public static void Main(string[] args)
    {
        Interface @interface = new Interface();
        @interface.rollDie(1, 20);
    }

}