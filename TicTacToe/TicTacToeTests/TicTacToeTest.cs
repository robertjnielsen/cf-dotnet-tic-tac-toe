using System;
using Xunit;
using TicTacToe;
using TicTacToe.Classes;

namespace TicTacToeTests
{
    public class TicTacToeTest
    {
        [Fact]
        public void CreatingPlayerObjectCanReturnTheNameOfTheNewPlayer()
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

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(9)]
        public void PlayerPositionMatchesCorrectBoardRowIndex(int userInput)
        {
            int boardRowValue;
            switch (userInput)
            {
                case 1:
                    boardRowValue = 0;
                    break;
                case 5:
                    boardRowValue = 1;
                    break;
                case 9:
                    boardRowValue = 2;
                    break;
                default:
                    boardRowValue = 0;
                    break;
            }

            Position testPosition = Player.PositionForNumber(userInput);

            Assert.Equal(boardRowValue, testPosition.Row);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(9)]
        public void PlayerPositionMatchesCorrectBoardColumnIndex(int userInput)
        {
            int boardRowValue;
            switch (userInput)
            {
                case 1:
                    boardRowValue = 0;
                    break;
                case 5:
                    boardRowValue = 1;
                    break;
                case 9:
                    boardRowValue = 2;
                    break;
                default:
                    boardRowValue = 0;
                    break;
            }

            Position testPosition = Player.PositionForNumber(userInput);

            Assert.Equal(boardRowValue, testPosition.Column);
        }
    }
}
