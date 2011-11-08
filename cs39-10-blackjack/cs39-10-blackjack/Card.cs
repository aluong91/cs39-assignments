using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_10_blackjack
{
	enum Face
	{
		Two = 2,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King,
		Ace
	}

	enum Suit
	{
		Spades,
		Clubs,
		Diamonds,
		Hearts
	}

	class Card
	{
		public Card(Face face, Suit suit)
		{
			Face = face;
			Suit = suit;
		}

		public readonly Face Face;
		public readonly Suit Suit;
	}
}
