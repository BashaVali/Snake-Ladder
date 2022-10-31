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
        public void PlayerPositionZeroRestart()
        {
            //local variable
            int rollDice, playerPosition = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            rollDice = random.Next(1, 6);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

            //Use random to check user option
            int index = random.Next(list.Count);
            Console.WriteLine("Player option is : " + list[index]);
            if (playerPosition + rollDice < 100)
            {
                if (list[index] == "Ladder") playerPosition += rollDice;
                if (list[index] == "Snake") playerPosition -= rollDice;
            }

            if (playerPosition < 0)
            {
                playerPosition = 0;
            }
            //Print to Console
            Console.WriteLine("\n");
            Console.WriteLine("Player current position : " + playerPosition);
            Console.WriteLine("Final position is :" + playerPosition);
        }
    }
}



