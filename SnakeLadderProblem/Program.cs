using SnakeAndLadderProblem;
using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlays gamePlay = new GamePlays();
            gamePlay.GamePlay();
            gamePlay.DiceRoll();
            gamePlay.CheckingPlayerPosition();
            gamePlay.PlayerPositionZeroRestart();
            gamePlay.PlayerPositionExact100();
            gamePlay.PositionOfDiceEveryTimePlayed();
            gamePlay.FinalReportOf2Players();

        }
    }
}