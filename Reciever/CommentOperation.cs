﻿using System.Collections.Generic;

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
		public SortedDictionary<string, int> SplitCommentsIntoWords(SortedDictionary<string, int> M, string comment)
		{
			// String for storing the words
			string word = "";
			List<string> words = new List<string>();

			for (int i = 0; i < comment.Length; i++)
			{

				if (comment[i] == ' ')
				{
					words.Add(word);
					word = "";
				}
				else
				{
					word += comment[i];
				}
			}
			word.ToLower();
			words.Add(word);

			return InsertWordsAndCount(M, words);
		}

		/// <summary>
		/// Inserting word and its count into a dictionary
		/// </summary>
		/// <param name="M"></param>
		/// <param name="words"></param>
		/// <returns></returns>
		private SortedDictionary<string, int> InsertWordsAndCount(SortedDictionary<string, int> M, List<string> words)
		{
			foreach (var word in words)
			{
				if (!M.ContainsKey(word))
				{
					M.Add(word, 1);
				}
				else
				{
					M[word]++;
				}
			}

			return M;
		}
	}
}