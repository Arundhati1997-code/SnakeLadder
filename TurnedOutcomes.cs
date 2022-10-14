using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public static class TurnedOutcomes
    {
        public static void Outcome()
        {
            string[] turnOutcomes = { "noPlay", "Ladder", "Snake" };
            Random randomNumber = new Random();
            var diceRoll = randomNumber.Next(1, 7);
            var turn = randomNumber.Next(0, 2);
            var playerPosition = 0;
            var turnResult = turnOutcomes[turn];
            switch (turnResult)
            {
                case "Ladder":
                    playerPosition = playerPosition + diceRoll;
                    break;
                case "Snake":
                    playerPosition = playerPosition - diceRoll;
                    break;
                default:
                case "noPlay":
                    break;
            }
            Console.WriteLine("Dice Rolled:{0},turn:{1},playerPosition:{2},turnresult:{3}", diceRoll, turn, playerPosition, turnResult);
        }
    }
}
