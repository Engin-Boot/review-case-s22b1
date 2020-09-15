using System;
using System.Collections.Generic;

namespace Receiver
{
	public static class Program
	{
		static void Main()
		{
			SortedDictionary<string, int> wordCountDictionary = new SortedDictionary<string, int>();
			FileOperation fileOperation = new FileOperation();
			CommentSplitter commentSplitter = new CommentSplitter();

			for (; ; )
			{

				string line = Console.ReadLine();
				if (string.IsNullOrEmpty(line))
				{
					break;
				}
				wordCountDictionary = commentSplitter.SplitCommentsIntoWords(wordCountDictionary, line);

			}
			fileOperation.WriteWordAndItsCount(wordCountDictionary);
		}
	}
}
