using System.Collections.Generic;

namespace Reciever
{
    public class Program
    {
        public static void Main()
        {
            #region Read Data From console
            FileOperation fileOperation = new FileOperation();
            List<string> commentsList = new List<string>();
            commentsList = fileOperation.ReadDataFromConsole();
            #endregion

            #region Write word count of comment
            
            fileOperation.CountWordsOfComment(commentsList, "demo.csv");
            fileOperation.WriteTotalCountInFile("demo.csv");
            #endregion
            
        }

    }   

 }

