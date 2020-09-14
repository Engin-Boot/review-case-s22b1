using System;
using System.Text;

namespace Receiver
{
    public class FormatComment
	{
		/// <summary>
		/// To remove all the Invalid Charater from string
		/// </summary>
		/// <param name="modifiedWord"></param>
		/// <returns></returns>
		public string RemoveInvalidCharacters(string word)
		{
			var modifiedWord = new StringBuilder();
			bool result;
			for (int i = 0; i < word.Length; i++)
			{
				result = Char.IsLetter(word[i]);
				if (result)
				{
					modifiedWord.Append(word[i]);
				}
			}
			return modifiedWord.ToString();
		}
	}
}
