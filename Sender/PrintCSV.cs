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
                if (!string.IsNullOrEmpty(line) && line.Contains(','))
                {
                    string columns = line.Split(',')[1];
                    if(!string.IsNullOrEmpty(columns))
                    {
                        PrintCSVCol(columns);
                    }
                 
                }
            }
        }

        /// <summary>
        /// Prints the column of CSV File
        /// </summary>
        /// <param name="columns"></param>
        private static void PrintCSVCol(string columns)
        {
            Console.WriteLine("{0}", columns);
        }
    }
}
