using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_09_tictactoe
{
	class Game
	{
		public Game(int first)
		{
			CurrentPlayer = first;
			Board = new int[3,3];
			HasWinner = false;
		}

		public bool Move(int x, int y)
		{
			if (Board[x,y] == 0) {
				Board[x,y] = CurrentPlayer;
				CheckWinner();
				return true;
			} else
				return false;
		}

		private void CheckWinner()
		{
			#region rows
			if ((Board[0, 0] != 0 && Board[0, 0] == Board[0, 1] && Board[0, 0] == Board[0, 2])
				|| (Board[1, 0] != 0 && Board[1, 0] == Board[1, 1] && Board[1, 0] == Board[1, 2])
				|| (Board[2, 0] != 0 && Board[2, 0] == Board[2, 1] && Board[2, 0] == Board[2, 2]))
				HasWinner = true;
			#endregion

			#region columns
			if ((Board[0, 0] != 0 && Board[0, 0] == Board[1, 0] && Board[0, 0] == Board[2, 0])
				|| (Board[0, 1] != 0 && Board[0, 1] == Board[1, 1] && Board[0, 1] == Board[2, 1])
				|| (Board[0, 2] != 0 && Board[0, 2] == Board[1, 2] && Board[0, 2] == Board[2, 2]))
				HasWinner = true;
			#endregion

			#region corners
			if ((Board[0, 0] != 0 && Board[0, 0] == Board[1, 1] && Board[0, 0] == Board[2, 2])
				|| (Board[2, 0] != 0 && Board[2, 0] == Board[1, 1] && Board[2, 0] == Board[0, 2]))
				HasWinner = true;
			#endregion

			NextPlayer();
		}

		private void NextPlayer()
		{
			CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
		}

		public int[,] Board { get; private set; }
		public int CurrentPlayer { get; private set; }
		public bool HasWinner { get; private set; }
	}
}
