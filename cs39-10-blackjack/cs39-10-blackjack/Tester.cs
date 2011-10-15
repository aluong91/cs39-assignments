using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_10_blackjack
{
	class Tester
	{
		public Tester()
		{
			#region shuffling
			Deck deck = new Deck(2, false);
			System.Console.WriteLine("The deck contains:");
			System.Console.WriteLine(deck.ToString());
			deck.Shuffle();
			System.Console.WriteLine("The shuffled deck contains:");
			System.Console.WriteLine(deck.ToString());
			#endregion

			#region dealing & hand values
			const int NumPlayers = 4;
			Game game = new Game(4, NumPlayers);
			for (int i = 0; i < NumPlayers + 1; ++i) {			// +1 because NumPlayers doesn't include dealer
				game.CurrentPlayer.Draw();
				System.Console.WriteLine("Player " + i + "\'s Hand");
				System.Console.WriteLine("Points: " + game.CurrentPlayer.Points);
				System.Console.WriteLine(game.CurrentPlayer.ToString());
				game.CurrentPlayer.Stand();
			}
			#endregion
		}
	}
}
