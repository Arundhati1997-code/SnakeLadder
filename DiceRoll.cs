using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class DiceRoll
    {
        public static void DiceRolled()
        {
            //for (int i = 0; i < 200; i++)
            {
                Random randomNumber = new Random();
                var diceRoll = randomNumber.Next(1, 7);
                Console.WriteLine("Dice rolled:{0}", diceRoll);

            }
        }
    }
}
