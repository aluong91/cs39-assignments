using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_02_assignmentvariables
{
	class Program
	{
		static void Main(string[] args)
		{
			bool isPlaying;
			char choice;
			Flipper coin = new Flipper();		// used to generate coin flips
			int numWins = 0, numLosses = 0;

			System.Console.Write("Feeling lucky? ");
			if (System.Console.ReadLine() == "y")
				isPlaying = true;
			else
				isPlaying = false;

			while (isPlaying) {
				System.Console.Write("'h' for heads, 't' for tails: ");
				choice = (char)System.Console.Read();
				System.Console.ReadLine();	// flush out the newline

				coin.flip();
				if (coin.result == 'h')
					System.Console.WriteLine("The coin was heads.");
				else
					System.Console.WriteLine("The coin was tails.");

				if (choice == coin.result) {
					numWins++;
					System.Console.WriteLine("You win a free iPod!");
				} 
				else {
					numLosses++;
					System.Console.WriteLine("So close! Here's a consolation prize.");
				}

				System.Console.WriteLine("\niPods Won: {0}", numWins);
				System.Console.WriteLine("Tissues Received: {0}\n", numLosses);

				System.Console.Write("Try again? ");
				if (System.Console.ReadLine() == "y")
					isPlaying = true;
				else
					isPlaying = false;
			}
		}
	}
}
