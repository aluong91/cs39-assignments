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
			hand = new List<Card>();
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

		public int Points
		{
			get
			{
				int numAces = 0, value = 0;

				foreach (Card card in hand) {
					if (card.Face == Face.Ace) {
						numAces++;
					} else if (card.Face < Face.Ten) {
						value += (int)card.Face;
					} else {
						value += 10;
					}
				}

				while (numAces > 0 && value < 21) {
					--numAces;
					if (value + 11 > 21) {
						++value;
					} else {
						value += 11;
					}
				}

				return value;
			}
		}

		public List<Card> hand { get; private set; }
		private Game game;
	}
}
