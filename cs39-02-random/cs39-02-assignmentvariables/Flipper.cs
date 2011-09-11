using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_02_assignmentvariables
{
	class Flipper
	{
		public Flipper()
		{
			flip();
		}

		public void flip()
		{
			int result = rand.Next(2);	// can be a 0 or 1
			if (result == 0)
				this.result = 'h';
			else
				this.result = 't';
		}

		public char result;
		private Random rand = new Random();
	}
}
