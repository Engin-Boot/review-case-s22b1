using System.IO;
using System.Reflection;
using System;

namespace Sender
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string csvPath;
            if (args.Length == 0)
            {
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                csvPath = path + "\\sample.csv";
            }
            else
            {
                csvPath = args[0];
            }

            String[] lines = ReadCSV(csvPath);
            PrintCSV obj = new PrintCSV();
            obj.PrintCSVRows(lines);
        }
        /// <summary> 
        /// This function reads the CSV File
        /// </summary>
        /// <param name="CSVPath"> CSV File Path </param>

        public static string[] ReadCSV(string CSVPath)
        {
            string[] lines = File.ReadAllLines(CSVPath);
            return lines;
        }    
    }
}

