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
								System.Console.WriteLine("Enter a sentence:");
								System.Console.WriteLine(countWords(System.Console.ReadLine()));
								break;
							case 2:
								System.Console.WriteLine("Enter a paragraph (q to quit):");
								// this calls the overloaded version of countWords() which accepts an array of strings
								System.Console.WriteLine(countWords(ReadParagraph().Split()));
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
								System.Console.WriteLine("Enter a sentence:");
								System.Console.WriteLine(countVowels(System.Console.ReadLine()));
								break;
							case 2:
								System.Console.WriteLine("Enter a paragraph (q to quit):");
								System.Console.WriteLine(countVowels(ReadParagraph()));
								break;
						}
						break;
					
					default:
						isCounting = false;
						break;
				}
			}
		}

		static int countWords(string input = "Hello")
		{
			// split the string into an arary of words, then return the # of elements in the array
			return input.Split().Length;
		}

		static int countWords(string[] input)
		{
			return input.Length;
		}

		static int countVowels(string input)
		{
			// similar to countWords(), but split if it contains a vowel
			return System.Text.RegularExpressions.Regex.Split(input, "[aeiou]").Length - 1;
		}

		static string ReadParagraph()
		{
			string result = System.String.Empty;	// this is the big string that gets returned
			string input;	// this is the current line thats being read
			bool shouldContinue = true;

			// keep reading until we get a 'q' on its own line
			do {
				input = System.Console.ReadLine().Trim();
				if (input == "q")
					shouldContinue = false;
				else
					result += " " + input;
			} while (shouldContinue);

			return result.Trim();	// trim makes sure that the string doesnt have any extra whitespace at the end
		}
	}
}