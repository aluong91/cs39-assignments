using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_10_blackjack
{
	class Deck
	{
		public Deck(int size = 1, bool shouldShuffle = true)
		{
			// fill the deck with each type of card
			for (int i = 0; i < size; i++)
				foreach (Face face in Enum.GetValues(typeof(Face)))
					foreach (Suit suit in Enum.GetValues(typeof(Suit)))
						cards.Add(new Card(face,suit));
			if (shouldShuffle)
				Shuffle();
		}

		public void Shuffle()
		{
			// randomly select cards from the original deck and then put them
			// into the shuffled deck
			List<Card> temp = new List<Card>();
			Random rand = new Random();
			int count = cards.Count;

			while (count > 0) {
				int index = rand.Next(count);
				temp.Add(cards[index]);
				cards.RemoveAt(index);
				count = cards.Count;
			}

			cards = temp;
		}

		public Card Draw()
		{
			Card result = cards[0];
			cards.RemoveAt(0);
			return result;
		}

		// for testing
		public override string ToString()
		{
			int count = 0;
			string result = String.Empty;
			foreach (Card card in cards) {
				result += card.Face.ToString() + ' ' + card.Suit.ToString() + Environment.NewLine;
				++count;
			}
			result += "Count: " + count + Environment.NewLine;
			return result;
		}

		private List<Card> cards = new List<Card>();
	}
}
