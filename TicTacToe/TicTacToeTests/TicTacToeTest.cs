using System;
using Xunit;
using TicTacToe;
using TicTacToe.Classes;

namespace TicTacToeTests
{
    public class TicTacToeTest
    {
        [Fact]
        public void CreatingPlayerOneReturnsTheNameOfPlayerOne()
        {
            string playerOne = "Dummmy";

            Player playerOneResult = Program.NewPlayer(playerOne);

            Assert.Equal(playerOneResult.Name, playerOne);
        }
    }
}
