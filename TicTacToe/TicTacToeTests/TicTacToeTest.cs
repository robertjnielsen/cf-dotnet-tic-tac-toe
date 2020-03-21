using System;
using Xunit;
using TicTacToe;
using TicTacToe.Classes;

namespace TicTacToeTests
{
    public class TicTacToeTest
    {
        [Fact]
        public void CreatingPlayerReturnsTheNameOfTheNewPlayer()
        {
            string playerNameInput = "Dummmy";

            Player NewPlayerResult = Program.NewPlayer(playerNameInput);

            Assert.Equal(NewPlayerResult.Name, playerNameInput);
        }

        [Fact]
        public void PlayerTurnsSwitchAfterAPlayerCompletesTheirTurn()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.IsTurn = true;
            Game testGame = new Game(playerOne, playerTwo);

            testGame.SwitchPlayer();
            Player nextPlayer = testGame.NextPlayer();

            Assert.Equal(playerTwo, nextPlayer);
        }
    }
}
