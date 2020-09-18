using System;
using System.Linq;
namespace Sender
{
    public class PrintCsv
    {
        /// <summary>
        /// Print all the rows of CSV File 
        /// </summary>
        /// <param name="lines"> </param>


        public void PrintCsvRows(string[] lines)
        {
            foreach (var columns in lines
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => x.Split(','))
                .Where(x => x.Length > 1 && !string.IsNullOrEmpty(x[1]))
                .ToArray())
            {
                PrintCsvCol(columns[1]);
            }
        }


        /// <summary>
        /// Prints the column of CSV File
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        private void PrintCsvCol(string columns)
        {
            foreach (var column in columns)
            {
                Console.Write("{0}", column);
            }
            Console.Write("\n");

        }
    }
}
