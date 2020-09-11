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
       
        public static void PrintCSVRows(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                PrintCSVCol(columns);
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Prints the column of CSV File
        /// </summary>
        /// <param name="columns"></param>
        private static void PrintCSVCol(string[] columns)
        {
            foreach (string column in columns)
            {
                Console.Write("\t{0}", column);
            }
        }
    }
}
