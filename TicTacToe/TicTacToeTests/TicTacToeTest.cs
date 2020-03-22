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

        [Theory]
        [InlineData(0, 0, 0, 1, 0, 2)]
        [InlineData(0, 0, 1, 1, 2, 2)]
        [InlineData(0, 0, 1, 0, 2, 0)]
        public void ReturnsTrueIfAWinnerIsDeclared(int row1, int col1, int row2, int col2, int row3, int col3)
        {
            Player testPlayerOne = new Player();
            testPlayerOne.Marker = "X";
            testPlayerOne.IsTurn = true;
            Player testPlayerTwo = new Player();
            testPlayerOne.Marker = "O";
            Game testGame = new Game(testPlayerOne, testPlayerTwo);
            testGame.Board.GameBoard[row1, col1] = testPlayerOne.Marker;
            testGame.Board.GameBoard[row2, col2] = testPlayerOne.Marker;
            testGame.Board.GameBoard[row3, col3] = testPlayerOne.Marker;

            bool isAWinner = testGame.CheckForWinner(testGame.Board);

            Assert.True(isAWinner);

        }

        [Fact]
        public void ReturnsTrueIfATieGameIsDeclared()
        {
            Player testPlayerOne = new Player();
            testPlayerOne.Marker = "X";
            string p1 = testPlayerOne.Marker;
            testPlayerOne.IsTurn = true;
            Player testPlayerTwo = new Player();
            testPlayerTwo.Marker = "O";
            string p2 = testPlayerTwo.Marker;
            Game testGame = new Game(testPlayerOne, testPlayerTwo);
            testGame.Board.GameBoard = new string[,]
            {
                { p1, p2, p1 },
                { p1, p1, p2 },
                { p2, p1, p2 }
            };

            bool isAWinner = testGame.CheckForWinner(testGame.Board);

            Assert.False(isAWinner);

        }
    }
}
