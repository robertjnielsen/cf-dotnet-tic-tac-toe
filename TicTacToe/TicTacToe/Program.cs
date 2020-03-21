using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic-Tac-Toe!");

            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.

            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.
        }

        public static void NewGame()
        {
            Console.WriteLine("Please enter a name for Player One:");
            string playerOneName = Console.ReadLine();
            Player PlayerOne = NewPlayer(playerOneName);
        }

        public static Player NewPlayer(string playerName)
        {
            Player newPlayer = new Player();
            newPlayer.Name = playerName;
            return newPlayer;
        }
    }
}
