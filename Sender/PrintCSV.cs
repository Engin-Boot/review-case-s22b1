using System;
using System.Linq;
using System.IO;
namespace Sender
{
    class PrintCSV
    {
        /// <summary>
        /// Print all the rows of CSV File 
        /// </summary>
        /// <param name="lines"> </param>


        public static void PrintCSVRows(string[] lines)
        {

            foreach (var columns in lines
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => x.Split(','))
                .Where(x => x.Length > 1 && !string.IsNullOrEmpty(x[1]))
                .ToArray())
            {
                PrintCSVCol(columns[1]);
            }
        }

        /// <summary>
        /// Prints the column of CSV File
        /// </summary>
        /// <param name="columns"></param>
        private static void PrintCSVCol(string columns)
        {
            foreach (var column in columns)
            {
                Console.Write("{0}", column);
            }
            Console.Write("\n");
        }
    }
}
