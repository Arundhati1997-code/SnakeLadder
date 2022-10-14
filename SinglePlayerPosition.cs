using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
     public class SinglePlayerPosition
    {
        private static int diceRoll;

        public static void Distance()
        {
            var playerPosition = 0;
            var timeRolled = 0;

            do
            {
                string[] turnOutcomes = {"noPlay", "Ladder", "Snake" };
                Random randomNumber = new Random();
                var diceRoll = randomNumber.Next(1, 7);
                timeRolled = timeRolled + 1;
                var turn = randomNumber.Next(0, 2);
                var turnResult = turnOutcomes[turn];
                if (playerPosition == 100)
                {
                    Console.WriteLine("Number of times the dice rolled:{0}", timeRolled);
                    break;
                }
                switch (turnResult)
                {
                    case "Ladder":
                        if (!((playerPosition + diceRoll) > 100))
                        {
                            playerPosition = playerPosition + diceRoll;
                        }
                        break;
                    case "Snake":
                        if (playerPosition - diceRoll < 0)
                        {
                            playerPosition = 0;
                        }
                        else
                        {
                            playerPosition = playerPosition - diceRoll;
                        }
                        break;
                  
                    default:
                    case "noPlay":
                       
                        break;
                }
                Console.WriteLine("Dice Rolled:{0},turn:{1},playerPosition:{2},turnresult:{3}", diceRoll, turn, playerPosition, turnResult);
            }
            while (playerPosition <= 100);


            if (((playerPosition + diceRoll) == 100))
            {
                playerPosition = playerPosition + diceRoll;
            }
            Console.WriteLine("Winner");
        }

    }
}
