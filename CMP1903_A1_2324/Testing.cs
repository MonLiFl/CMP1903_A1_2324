using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Method for testing
        public void TestGame()
        {
            try
            {
                // Instance of the game 
                Game game = new Game();

                // Output to see which results are the test results
                Console.WriteLine("Testing");
                
                // Uses the rolls Method in the Game class
                game.Rolls();

                // Checks if every die roll value is >= 1 and <= 6 
                Debug.Assert(game.die1.RollValue >= 1 && game.die1.RollValue <= 6, "Die 1 result is not between 1 and 6 (inclusive)");
                Debug.Assert(game.die2.RollValue >= 1 && game.die2.RollValue <= 6, "Die 2 result is not between 1 and 6 (inclusive)");
                Debug.Assert(game.die3.RollValue >= 1 && game.die3.RollValue <= 6, "Die 3 result is not between 1 and 6 (inclusive)");

                // Variables which are the min and max sums for 3 dice
                int minSum = 3;
                int maxSum = 18;

                // Adds the total of 3 dice
                int actualSum = game.die1.RollValue + game.die2.RollValue + game.die3.RollValue;
                // Checks if the total is >= 3 and <= 18 
                Debug.Assert(actualSum >= minSum && actualSum <= maxSum, "The actual sum of dice values is within the allowed ranges (3-18 inclusive)");
            }
            // Catch exception to handle any errors
            catch (Exception)
            {
                Console.WriteLine("An error occured in the testing of code");
            }
        }
    }
}