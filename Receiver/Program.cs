using System;
using System.Collections.Generic;

namespace Receiver
{
	class Program
	{
		static void Main()
		{
			SortedDictionary<string, int> wordCountDictionary = new SortedDictionary<string, int>();
			string line = "";
			FileOperation fileOperation = new FileOperation();
			CommentSplitter commentSplitter = new CommentSplitter();

			for (; ; )
			{

				line = Console.ReadLine();
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
