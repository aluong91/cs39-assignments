using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_10_blackjack
{
	class Player
	{
		public Player(Game game)
		{
			this.game = game;
		}

		public void Draw()
		{
			hand.Add(game.Draw());
		}

		public void Stand()
		{
			game.NextPlayer();
		}

		// for testing
		public override string ToString()
		{
			int count = 0;
			string result = String.Empty;
			foreach (Card card in hand) {
				result += card.Face.ToString() + ' ' + card.Suit.ToString() + Environment.NewLine;
				++count;
			}
			result += "Count: " + count + Environment.NewLine;
			return result;
		}

		private Game game;
		private List<Card> hand = new List<Card>();
	}
}
