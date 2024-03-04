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
                Game game = new Game();

                game.Rolls();

                Testing testing = new Testing();

                testing.TestGame();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured in the main method");
            }
        }
    }
}