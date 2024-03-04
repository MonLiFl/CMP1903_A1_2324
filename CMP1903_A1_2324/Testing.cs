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
        public void TestGame()
        {
            try
            {

                Game game = new Game();

                game.Rolls();

                Debug.Assert(game.die1.RollValue >= 1 && game.die1.RollValue <= 6, "Die 1 result is not between 1 and 6 (inclusive)");
                Debug.Assert(game.die2.RollValue >= 1 && game.die2.RollValue <= 6, "Die 2 result is not between 1 and 6 (inclusive)");
                Debug.Assert(game.die3.RollValue >= 1 && game.die3.RollValue <= 6, "Die 3 result is not between 1 and 6 (inclusive)");

                int minSum = 3;
                int maxSum = 18;

                int actualSum = game.die1.RollValue + game.die2.RollValue + game.die3.RollValue;
                Debug.Assert(actualSum >= minSum && actualSum <= maxSum, "The actual sum of dice values is within the allowed ranges (3-18 inclusive)");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured in the testing of code");
            }
        }
    }
}