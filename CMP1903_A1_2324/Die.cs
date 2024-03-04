using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        public Die() { }

        private static Random random = new Random();

        public int RollValue { get; private set; }

        public int Roll()
        {
            try
            {
                RollValue = random.Next(1, 7);
                return RollValue;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured in generating a random value");
                return 1;
            }
        }
    }
}