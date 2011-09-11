using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_39_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			bool isCounting = true;

			while (isCounting) {
				System.Console.WriteLine("\n1. Word counting");
				System.Console.WriteLine("2. Vowel counting");
				System.Console.WriteLine("3. Exit");
				System.Console.Write("Enter selection: ");
				int choice = int.Parse(System.Console.ReadLine());

				switch (choice)
				{
					case 1:
						System.Console.WriteLine("\n1. Count the words in one sentence");
						System.Console.WriteLine("2. Count the words in one paragraph");
						System.Console.WriteLine("3. Exit");
						System.Console.Write("Enter selection: ");
						choice = int.Parse(System.Console.ReadLine());
						switch (choice)
						{
							case 1:
								countWords();
								break;
							case 2:
								countWords();
								break;
						}
						break;
	
					case 2:
						System.Console.WriteLine("\n1. Count the vowels in one sentence");
						System.Console.WriteLine("2. Count the vowels in one paragraph");
						System.Console.WriteLine("3. Exit");
						System.Console.Write("Enter selection: ");
						choice = int.Parse(System.Console.ReadLine());
						switch (choice)
						{
							case 1:
								countVowels();
								break;
							case 2:
								countVowels();
								break;
						}
						break;
					
					default:
						isCounting = false;
						break;
				}
			}
		}

		static bool countWords()
		{
			return true;
		}

		static bool countVowels()
		{
			return true;
		}

	}
}
