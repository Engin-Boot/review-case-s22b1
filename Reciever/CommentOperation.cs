﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reciever
{
	
	public class CommentOperation
    {

		
		/// <summary>
		/// splitting the text and storing the splitted words into the list 
		/// </summary>
		/// <param name="M"></param>
		/// <param name="line"></param>
		/// <returns></returns>
		public SortedDictionary<string, int> SplitCommentsIntoWords(SortedDictionary<string, int> wordCountMap, string comment)
		{
			// String for storing the words
			string word = "";
			List<string> words = new List<string>();

			for (int i = 0; i < comment.Length; i++)
			{

				if (comment[i] == ' ')
				{
					word = word.ToLower();
					word = RemoveInvalidCharacters(word);
					words.Add(word);
					word = "";
				}
				else
				{
					word += comment[i];
				}
			}
			
			
			words.Add(word);

			
			return InsertWordsAndCount(wordCountMap, words);
		}

		/// <summary>
		/// Inserting word and its count into a dictionary
		/// </summary>
		/// <param name="M"></param>
		/// <param name="words"></param>
		/// <returns></returns>
		private SortedDictionary<string, int> InsertWordsAndCount(SortedDictionary<string, int> mapOfWordCount, List<string> words)
		{
			foreach (var word in words)
			{
				if (!mapOfWordCount.ContainsKey(word))
				{
					mapOfWordCount.Add(word, 1);
				}
				else
				{
					mapOfWordCount[word]++;
				}
			}

			return mapOfWordCount;
		}


		/// <summary>
		/// To remove all the Invalid Charater from string
		/// </summary>
		/// <param name="modifiedWord"></param>
		/// <returns></returns>
		private string RemoveInvalidCharacters(string word)
        {
			var modifiedWord = new StringBuilder();
			bool result;
			for (int i = 0; i < word.Length; i++)
			{
				result = Char.IsLetter(word[i]);
				if (result)
				{
					modifiedWord.Append(word[i]);
				}
			}
			return modifiedWord.ToString();
		}
	}
}
