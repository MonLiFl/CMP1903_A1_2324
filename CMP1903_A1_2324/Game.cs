using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public Die die1;
        public Die die2;
        public Die die3;
        private int total = 0;

        public Game()
        {
            die1 = new Die();
            die2 = new Die();
            die3 = new Die();

        }
        public void Rolls()
        {
            try
            {
                int roll1 = die1.Roll();
                int roll2 = die2.Roll();
                int roll3 = die3.Roll();

                total = roll1 + roll2 + roll3;

                Console.WriteLine("Die 1 result: " + roll1);
                Console.WriteLine("Die 2 result: " + roll2);
                Console.WriteLine("Die 3 result: " + roll3);
                Console.WriteLine("Total of all 3 dice rolls: " + total);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured while dice rolling");
            }
        }
    }
}