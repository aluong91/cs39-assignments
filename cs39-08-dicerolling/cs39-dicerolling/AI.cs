using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_dicerolling
{
	class AI
	{
		public AI(Game game)
		{
			this.game = game;
		}

		public void Go()
		{
			if (game.TurnScore > 20)
				game.Stand();
			else
				game.Roll();
		}

		private Game game;
	}
}
