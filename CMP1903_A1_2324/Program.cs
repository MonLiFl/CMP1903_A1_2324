using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creates a game object
                Game game = new Game();

                // Calls the Rolls method in the game class
                game.Rolls();

                // Creates a testing object
                Testing testing = new Testing();

                // Calls the TestGame method in the testing class
                testing.TestGame();
            }
            // Catch exception to handle any errors
            catch (Exception)
            {
                Console.WriteLine("An error occured in the main method");
            }
        }
    }
}