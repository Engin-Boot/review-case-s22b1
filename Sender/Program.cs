using System.IO;
using System.Reflection;

namespace Sender
{
    internal class Program
    {
        internal static void Main(string[] args)
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
            ReadCSV(csvPath);
        }

        /// <summary> 
        /// This function reads the CSV File
        /// </summary>
        /// <param name="CSVPath"> CSV File Path </param>

        public static void ReadCSV(string CSVPath)
        {
            string[] lines = File.ReadAllLines(CSVPath);
            PrintCSV.PrintCSVRows(lines);
        }
    }
}

