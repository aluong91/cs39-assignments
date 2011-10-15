using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_10_blackjack
{
	class Game
	{
		public Game(int numDecks = 1, int numPlayers = 1)
		{
			deck = new Deck(numDecks);

			for (int i = 0; i < numPlayers + 1; ++i) {
				players.Add(new Player(this));
			}
			playerEnumerator = players.GetEnumerator();
			Deal();
		}

		private void Deal()
		{
			playerEnumerator.Reset();
			playerEnumerator.MoveNext();

			// give each player two cards
			for (int i = 0; i < 2; ++i) {
				while (CurrentPlayer != null) {
					CurrentPlayer.Draw();
					playerEnumerator.MoveNext();
				}
				playerEnumerator.Reset();
				playerEnumerator.MoveNext();
			}
		}

		public Player CurrentPlayer
		{
			get { return playerEnumerator.Current; }
		}

		public Card Draw()
		{
			return deck.Draw();
		}

		public void NextPlayer()
		{
			playerEnumerator.MoveNext();

			// if we reached the end of the list, all the players have went
			// and it's now the dealer's turn
			if (CurrentPlayer == null) {
				playerEnumerator.Reset();
				playerEnumerator.MoveNext();
				DealerPlay();
			}
		}

		private void DealerPlay()
		{
			playerEnumerator.Current.Stand();
		}

		private Deck deck;
		private List<Player> players = new List<Player>();
		private IEnumerator<Player> playerEnumerator;
	}
}
