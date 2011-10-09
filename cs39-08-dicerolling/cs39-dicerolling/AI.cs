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
			timer = new System.Timers.Timer();
			timer.Interval = 500;
			timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
		}

		public void Go()
		{
			timer.Start();
		}

		private void timer_Elapsed(object e, EventArgs a)
		{
			if (game.TurnScore > 20)
				game.Stand();

			if (game.CurrentPlayer != 2)
				timer.Stop();
			else
				game.Roll();
		}

		private Game game;
		private System.Timers.Timer timer;
	}
}
