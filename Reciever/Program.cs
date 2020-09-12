using System;
using System.Collections.Generic;


namespace Reciever
{
    public static class Program
	{
		static void Main()
		{
			SortedDictionary<string, int> M = new SortedDictionary<string, int>();
			string line = "";
			CommentOperation commentOperation = new CommentOperation();
			FileOperation fileOperation = new FileOperation();
			
			for(; ; )
			{
			
				line = Console.ReadLine();
				if (string.IsNullOrEmpty(line))
				{
					break;
				}
				M = commentOperation.SplitCommentsIntoWords(M, line);
				
			}
			fileOperation.WriteWordAndItsCount(M);
		}
	}

}
