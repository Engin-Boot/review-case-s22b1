using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class Program
    {
		static void Main()
		{
			SortedDictionary<string, int> wordCountDictionary = new SortedDictionary<string, int>();
			string line = "";
			CommentOperation commentOperation = new CommentOperation();
			FileOperation fileOperation = new FileOperation();

			for (; ; )
			{

				line = Console.ReadLine();
				if (string.IsNullOrEmpty(line))
				{
					break;
				}
				wordCountDictionary = commentOperation.SplitCommentsIntoWords(wordCountDictionary, line);

			}
			fileOperation.WriteWordAndItsCount(wordCountDictionary);
		}
	}
}
