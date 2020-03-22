using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application. Creates two new Player instances, a new Game instance, and outputs the results of the game to the console.
        /// </summary>
        /// <param name="args">Application arguments that may be passed at runtime.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic-Tac-Toe!");
            Console.WriteLine();

            Console.WriteLine("Please enter a name for Player One:");
            string playerOneName = Console.ReadLine();
            Player playerOne = new Player();
            playerOne.Name = playerOneName;
            playerOne.Marker = "X";

            Console.WriteLine("Please enter a name for Player Two:");
            string playerTwoName = Console.ReadLine();
            Player playerTwo = new Player();
            playerTwo.Name = playerTwoName;
            playerTwo.Marker = "O";

            Game game = new Game(playerOne, playerTwo);

            Player winner = game.Play();

            game.Board.DisplayBoard();
            Console.WriteLine();
            if (winner != null)
            {
                Console.WriteLine($"{winner.Name}, you've won!");
            }
            else if (winner == null)
            {
                Console.WriteLine("It's a draw! Nobody wins...");
            }
        }
    }
}
