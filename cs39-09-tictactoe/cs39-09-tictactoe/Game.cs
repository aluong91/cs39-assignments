using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_09_tictactoe
{
	class Game
	{
		public Game()
		{
			Board = new int[3,3];
			CurrentPlayer = 1;
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
			bool isSame;
			int first, current;

			// traverse each row for a winnner
			for (int i = 0; i < Board.GetLength(0); i++)
			{
				isSame = true;
				first = Board[i, 0];
				for (int j = 1; j < Board.GetLength(1); j++)
				{
					current = Board[i, j];
					if (first != current)
						isSame = false;
				}
				if (isSame == true)
					HasWinner = true;
			}

			// traverse each column for a winnner
			for (int i = 0; i < Board.GetLength(0); i++)
			{
				isSame = true;
				first = Board[0, i];
				for (int j = 1; j < Board.GetLength(1); j++)
				{
					current = Board[j, i];
					if (first != current)
						isSame = false;
				}
				if (isSame == true)
					HasWinner = true;
			}

			// check diagonals
			if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2]
				|| Board[2, 0] == Board[1, 1] && Board[1, 1] == Board[0, 2])
				HasWinner = true;

			if (!HasWinner)
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
