using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Reciever
{
    public class FileOperation
    {
        static int totalOfWordCount = 0;

        /// <summary>
        /// Reading data from the console and storing into a list
        /// </summary>
        /// <returns></returns>
        public List<string> ReadDataFromConsole()
        {
            List<string> comments = new List<string>();
            string input;
            int position;

            for (; ; )
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                position = input.IndexOf(",");
                comments.Add(input.Substring(position + 1));
            }

            return comments;
        }

        /// <summary>
        /// Counting the number of words present in the comment column of CSV file
        /// </summary>
        /// <param name="comments"></param>
        /// <param name="filePath"></param>
        public void CountWordsOfComment(List<string> comments, string filePath)
        {
            #region Writing Word Count in CSV File
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                foreach (string comment in comments)
                {
                    int wordCount;

                    wordCount = CalculatingIndex(comment);

                    totalOfWordCount += wordCount;

                    file.WriteLine(wordCount);


                }
            }
            #endregion
        }

        private int CalculatingIndex(string inputComment)
        {
            int count = 0;
            string pattern = "[^\\w]";
            
            //get all spaces and other signs, like: '.' '?' '!'
            string[] words;
            int i;
            words = Regex.Split(inputComment, pattern, RegexOptions.IgnoreCase);
            
            for (i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                if (words[i].ToString() == string.Empty)
                    count--;
                count++;
            }
            return count;
        }

     
       
        /// <summary>
        /// Writing total count of words in the csv 
        /// </summary>
        /// <param name="filePath"></param>
        public void WriteTotalCountInFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Total" + " " + totalOfWordCount);
            }
        }
    }
}
