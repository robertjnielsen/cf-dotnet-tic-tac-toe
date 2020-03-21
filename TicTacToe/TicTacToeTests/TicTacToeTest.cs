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
    }
}
