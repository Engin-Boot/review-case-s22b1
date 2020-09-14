using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    class PrintCSV
    {
        /// <summary>
        /// Print all the rows of CSV File 
        /// </summary>
        /// <param name="lines"> </param>

        //public static void PrintCSVRows(string[] lines)
        //{

        //    foreach (string line in lines)
        //    {
        //        if (!string.IsNullOrEmpty(line) && line.Contains(','))
        //        {
        //            string columns = line.Split(',')[1];
        //            if (!string.IsNullOrEmpty(columns))
        //            {
        //                PrintCSVCol(columns);
        //            }

        //        }
        //    }
        //}

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
            Console.WriteLine("\n");
        }
    }
}
