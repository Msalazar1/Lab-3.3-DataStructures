using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
			while (true)
			{

				Console.Write("Want to reverse a word? Type it here: ");
				string input = Console.ReadLine();


				Console.WriteLine($"Your word in reverse is: {Reverse(input)}");


				Console.Write("\nWant to reverse another word? yes or no: ");
				string keepgoing = Console.ReadLine().ToLower();
				while (!(keepgoing == "yes" || keepgoing == "no"))
				{
					Console.Write("\n Oops!  Something went wrong.  Please enter yes or no: ");
					keepgoing = Console.ReadLine().ToLower();
				}
				if (keepgoing == "no" || keepgoing == "n")
				{
					break;
				}
				else
				{
					Console.Clear();
				}
			}
		}
		static string Reverse(string sentence)
		{
			string reversedSentence = "";

			string[] words = sentence.Split(' ');

			foreach (string word in words)
			{
				string reversedWord = "";

				Stack<char> reverseOrder = new Stack<char>();

				char[] letters = word.ToCharArray();
				foreach (char letter in letters)
				{
					reverseOrder.Push(letter);
				}

				while (reverseOrder.TryPop(out char currentLetter))
				{
					reversedWord += currentLetter;
				}

				reversedSentence += (reversedWord + " ");
			}

			return reversedSentence;
		}
	}
}
