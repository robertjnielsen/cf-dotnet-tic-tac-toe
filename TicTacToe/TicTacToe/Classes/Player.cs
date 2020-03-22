using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    public class Player
    {
		public string Name { get; set; }

		/// <summary>
		/// P1 is X and P2 will be O.
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn.
		/// </summary>
		public bool IsTurn { get; set; }

		/// <summary>
		/// Asks the user to choose a position on the board, and calls PositionForNumber to determine matching coordinates on the board for the user's input.
		/// </summary>
		/// <param name="board">The Board instance being 'played' on.</param>
		/// <returns>Returns a set of coordinates on the board that coincide with the user's integer input.</returns>
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location:");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}

		/// <summary>
		/// Compares the user's integer input with the coordinates in the game board's 2d matrix.
		/// </summary>
		/// <param name="position">The user's integer input.</param>
		/// <returns>Returns a Position instance that represents a point within the game board's 2d matrix.</returns>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}

		/// <summary>
		/// Asks a user to enter a position on the board they would like to mark. Adds their mark to that position if it is not already occupied.
		/// </summary>
		/// <param name="board">The current game Board instance.</param>
		/// <returns>Returns a boolean value determined by whether or not the position the user selected has been previously marked or not.</returns>
		public bool TakeTurn(Board board)
		{
			IsTurn = true;

			Console.WriteLine($"{Name}, it is your turn.");

			Position position = GetPosition(board);

			if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
			{
				board.GameBoard[position.Row, position.Column] = Marker;
				return true;
			}
			else
			{
				Console.WriteLine("This space is already occupied");
				return false;
			}
		}
	}
}
