using System;
using System.Text;

namespace Receiver
{
    public class FormatComment
	{
		/// <summary>
		/// To remove all the invalid characters from string
		/// </summary>
		/// <param name="word"></param>
		/// <returns></returns>
		public string RemoveInvalidCharacters(string word)
		{
			var modifiedWord = new StringBuilder();
			foreach (char character in word)
			{
				bool result = Char.IsLetter(character);
				if (result)
				{
					modifiedWord.Append(character);
				}
			}
			return modifiedWord.ToString();
		}
	}
}
