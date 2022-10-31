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
    }
}



