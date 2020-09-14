using System;
using System.Collections.Generic;
using System.Text;

namespace Receiver
{
	public class MapOpeartion
	{
		/// <summary>
		/// Inserting word and its count into a dictionary
		/// </summary>
		/// <param name="M"></param>
		/// <param name="words"></param>
		/// <returns></returns>
		public SortedDictionary<string, int> InsertWordsAndCount(SortedDictionary<string, int> mapOfWordCount, List<string> words)
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
	}
}
