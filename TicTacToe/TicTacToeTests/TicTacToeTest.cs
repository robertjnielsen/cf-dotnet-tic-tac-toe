using System;
using Xunit;
using TicTacToe;
using TicTacToe.Classes;

namespace TicTacToeTests
{
    public class TicTacToeTest
    {
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

        [Fact]
        public void ReturnsTrueIfAWinnerIsDeclared()
        {
            Player testPlayerOne = new Player();
            testPlayerOne.Marker = "X";
            testPlayerOne.IsTurn = true;
            Player testPlayerTwo = new Player();
            testPlayerOne.Marker = "O";
            Game testGame = new Game(testPlayerOne, testPlayerTwo);
            testGame.Board.GameBoard[0, 0] = testPlayerOne.Marker;
            testGame.Board.GameBoard[0, 1] = testPlayerOne.Marker;
            testGame.Board.GameBoard[0, 2] = testPlayerOne.Marker;

            bool isAWinner = testGame.CheckForWinner(testGame.Board);

            Assert.True(isAWinner);

        }
    }
}
