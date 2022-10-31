using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class GamePlays
    {
        //Declared Local variable
        int rollDice, playerPosition = 0, playerPosition1 = 0, playerPosition2 = 0;
        int count = 0;
        //UC-1
        public void GamePlay()
        {

            Console.WriteLine("Game is Start:" + playerPosition);
        }
        public void DiceRoll()
        {
            int playerPos = 0, rollDice;
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
        }
        public void CheckingPlayerPosition()
        {
            int playerPosition = 0, rollDice;
            //creates random number for rolling dice
            Random random = new Random();
            rollDice = random.Next(1, 6);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
            // print user option
            Console.WriteLine("Player Option 1.No Play 2.Ladder 3.Snake");
            var list = new List<string> { "No Play", "Ladder", "Snake" };
            //check user option
            int pos = random.Next(list.Count);
            //condition based on user option
            if (list[pos] == "Ladder")
            {
                playerPosition += rollDice;

            }
            else if (list[pos] == "Snake")
            {
                playerPosition -= rollDice;

            }
            //print result of playerposition and dice rolled
            Console.WriteLine("Player option:" + list[pos]);
            Console.WriteLine("player updated position:" + playerPosition);
        }
    }
}



