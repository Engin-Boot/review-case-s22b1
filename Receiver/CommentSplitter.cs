using System.Collections.Generic;

namespace Receiver
{
    public class CommentSplitter
	{

		/// <summary>
		/// splitting the text and storing the splitted words into the list
		/// </summary>
		/// <param name="wordCountMap"></param>
		/// <param name="comment"></param>
		/// <returns></returns>
		public SortedDictionary<string, int> SplitCommentsIntoWords(SortedDictionary<string, int> wordCountMap, string comment)
		{
			FormatComment formatComment = new FormatComment();
			MapOpeartion mapOpeartion = new MapOpeartion();
			List<string> words = new List<string>(comment.Split(' '));
			for (int i = 0; i < words.Count; i++)
			{
				words[i] = words[i].ToLower();
				words[i] = formatComment.RemoveInvalidCharacters(words[i]);
			}
			return mapOpeartion.InsertWordsAndCount(wordCountMap, words);
		}
	}
}
