using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeAndLadderVersionThree
    {
        public static void Multiplayer()
        {
            var playerOne = 0;
            var playerTwo = 0;
            var playerOneTimeRolled = 0;
            var playerTwoTimeRolled = 0;
            var currentPlayer = "Player One";

            do
            {
                string[] turnOutcomes = { "noPlay", "Ladder", "Snake" };
                Random randomNumber = new Random();
                var diceRoll = randomNumber.Next(1, 6);
                if (currentPlayer == "Player One")
                {
                    playerOneTimeRolled = playerOneTimeRolled + 1;
                }
                else
                {
                    playerTwoTimeRolled = playerTwoTimeRolled + 1;
                }


                var turn = randomNumber.Next(0, 2);
                var turnResult = turnOutcomes[turn];

                if (playerOne == 100)
                {
                    Console.WriteLine("Player One is the winner and Number of times the dice rolled for Player One is:{0}", playerOneTimeRolled);
                    break;
                }
                if (playerTwo == 100)
                {
                    Console.WriteLine("Player Two is the winner and Number of times the dice rolled for Player Two is:{0}", playerTwoTimeRolled);
                    break;
                }
                Console.WriteLine("While Dice is being Rolled:Dice Rolled:{0},CurrentPlayer:{1}", diceRoll, currentPlayer);


                switch (turnResult)
                {
                    case "Ladder":
                        if (currentPlayer == "Player One")
                        {
                            if (!((playerOne + diceRoll) > 100))
                            {
                                playerOne = playerOne + diceRoll;
                            }
                        }
                        else
                        {
                            if (!((playerTwo + diceRoll) > 100))
                            {
                                playerTwo = playerTwo + diceRoll;
                            }

                        }


                        break;
                    case "Snake":
                        if (currentPlayer == "Player One")
                        {
                            if (playerOne - diceRoll < 0)
                            {
                                playerOne = 0;
                            }
                            else
                            {
                                playerOne = playerOne - diceRoll;
                            }
                            currentPlayer = "Player Two";

                        }
                        else
                        {
                            if (playerTwo - diceRoll < 0)
                            {
                                playerTwo = 0;
                            }
                            else
                            {
                                playerTwo = playerTwo - diceRoll;
                            }
                            currentPlayer = "Player One";
                        }
                        break;



                    case "noPlay":
                        if (currentPlayer == "Player One")
                        {
                            currentPlayer = "Player Two";
                        }
                        else
                        {
                            currentPlayer = "Player One";
                        }
                        break;

                    default:
                        break;

                }
                Console.WriteLine("After Dice Rolled:Dice Rolled:{0},playerOne:{1},playerTwo:{3} turnresult:{2}", diceRoll, playerOne, turnResult, playerTwo);
            }
            while ((playerOne <= 100) || (playerTwo <= 100));
        }
    }
}
