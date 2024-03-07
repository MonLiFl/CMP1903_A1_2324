using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Creates 3 dice objects
        public Die die1;
        public Die die2;
        public Die die3;
        // variable to set initial roll total to 0
        public int rollTotal = 0;

        // Initialises the 3 dice objects
        public Game()
        {
            die1 = new Die();
            die2 = new Die();
            die3 = new Die();

        }

        // Method for rolling
        public void Rolls()
        {
            try
            {
                // Rolls every dice
                int roll1 = die1.Roll();
                int roll2 = die2.Roll();
                int roll3 = die3.Roll();

                // Adds the roll values into a total
                rollTotal = roll1 + roll2 + roll3;

                // Outputs the result of each die
                Console.WriteLine("Die 1 result: " + roll1);
                Console.WriteLine("Die 2 result: " + roll2);
                Console.WriteLine("Die 3 result: " + roll3);
                // Total of 3 dice
                Console.WriteLine("Total of all 3 dice rolls: " + rollTotal);
            }
            // Catch exception to handle any errors
            catch (Exception)
            {
                Console.WriteLine("An error occured while dice rolling");
            }
        }
    }
}