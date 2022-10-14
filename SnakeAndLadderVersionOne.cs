using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeAndLadderVersionOne
    {
        public static void VersionOne()
        {
            var playerPosition = 0;
            do
            {
                string[] turnOutcomes = { "noPlay", "Ladder", "Snake" };
                Random randomNumber = new Random();
                var diceRoll = randomNumber.Next(1, 7);
                var turn = randomNumber.Next(0, 2);
                var turnResult = turnOutcomes[turn];
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
            while (playerPosition < 100);
        }
    }
}
