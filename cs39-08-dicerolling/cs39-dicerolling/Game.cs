using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_dicerolling
{
	public delegate void Callback();		// used to notify the form that the score has been updated

	class Game
	{
		public Game(Callback cb)
		{
			CurrentPlayer = 1;
			TurnScore = Player1Score = Player2Score = 0;
			Dice = new Roller(1, 6);
			this.UpdateScoreboard = cb;
		}

		public void Roll()
		{
			Dice.Roll();
			if (Dice.Value == 1) {
				NextPlayer();
			} else
				TurnScore += Dice.Value;
			UpdateScoreboard();
		}

		public void Stand()
		{
			AddToTotal();
			NextPlayer();
			UpdateScoreboard();
		}

		private void AddToTotal()
		{
			if (CurrentPlayer == 1)
				Player1Score += TurnScore;
			else
				Player2Score += TurnScore;
		}

		private void NextPlayer()
		{
			TurnScore = 0;
			CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
		}

		public int CurrentPlayer { get; private set; }
		public int TurnScore { get; private set; }
		public int Player1Score { get; private set; }
		public int Player2Score { get; private set; }
		public Roller Dice { get; private set; }

		private Callback UpdateScoreboard;
	}
}
