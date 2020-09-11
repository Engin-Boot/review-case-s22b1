using System;
using System.IO;

namespace Sender
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string CSVPath = @"C:\VARNIKA\CommentFileCSV.csv";
            ReadCSV(CSVPath);
            Console.ReadKey();
        }

        /// <summary> 
        /// This function reads the CSV File
        /// </summary>
        /// <param name="CSVPath"> CSV File Path </param>

        public static void ReadCSV(string CSVPath)
        {
            string[] lines = File.ReadAllLines(CSVPath);
            Console.WriteLine("\n\tCSV Data \n");
            PrintCSV.PrintCSVRows(lines);
        }          
    }
}

