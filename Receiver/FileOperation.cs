﻿using System.Collections.Generic;
using System.IO;

namespace Receiver
{
	public class FileOperation
	{
		/// <summary>
		/// Writing dictionary into the CSV file
		/// </summary>
		/// <param name="mapOfWordCount"></param>
		public bool WriteWordAndItsCount(SortedDictionary<string, int> mapOfWordCount)
		{
			bool success = false;
            using StreamWriter file = new StreamWriter("demo.csv", true);
            foreach (KeyValuePair<string, int> keyValuePair in mapOfWordCount)
            {
                file.WriteLine("{0},{1}", keyValuePair.Key, keyValuePair.Value);
				success = true;
            }
			return success;
        }
	}
}
