using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic-Tac-Toe!");
            Game game = NewGame();

            game.Play();

            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.
        }

        /// <summary>
        /// Creates a new Game instance, and assigns two new Player instances to the object.
        /// </summary>
        /// <returns>Returns a new Game object.</returns>
        public static Game NewGame()
        {
            Console.WriteLine("Please enter a name for Player One:");
            string playerOneName = Console.ReadLine();
            Player playerOne = NewPlayer(playerOneName);
            playerOne.Marker = "X";

            Console.WriteLine("Please enter a name for Player Two:");
            string playerTwoName = Console.ReadLine();
            Player playerTwo = NewPlayer(playerTwoName);
            playerTwo.Marker = "O";

            Game newGame = new Game(playerOne, playerTwo);

            return newGame;
        }

        /// <summary>
        /// Creates a new Player instance, and assigns the Name property of the Player object to the user's input.
        /// </summary>
        /// <param name="playerName">User input to be assigned as the Name property of the new Player object.</param>
        /// <returns>Returns the new Player object, with a user determined Name property.</returns>
        public static Player NewPlayer(string playerName)
        {
            Player newPlayer = new Player();
            newPlayer.Name = playerName;
            return newPlayer;
        }
    }
}
