using System.Collections.Generic;
using System.IO;

namespace Receiver
{
	public class FileOperation
	{
		/// <summary>
		/// Writing words and its count of dictionary to the csv file
		/// </summary>
		/// <param name="M"></param>
		public void WriteWordAndItsCount(SortedDictionary<string, int> M)
		{
			using (StreamWriter file = new StreamWriter("demo.csv", true))
			{
				foreach (KeyValuePair<string, int> keyValuePair in M)
				{
					file.WriteLine("{0},{1}", keyValuePair.Key, keyValuePair.Value);
				}
			}
		}
	}
}
