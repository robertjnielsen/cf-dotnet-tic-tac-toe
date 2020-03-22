using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    public class Position
    {
		public int Row { get; set; }
		public int Column { get; set; }

		/// <summary>
		/// Position on the gameboard being initialized.
		/// </summary>
		/// <param name="row">Row number.</param>
		/// <param name="column">Column number.</param>
		public Position(int row, int column)
		{
			Row = row;
			Column = column;
		}
	}
}
