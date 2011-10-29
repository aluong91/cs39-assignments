﻿using System;
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
		Jack = 10,
		Queen = 10,
		King = 10,
		Ace = 11
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
