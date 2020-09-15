using Sender;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace Sender_Test
{
    public class UnitTest1
    {
        [Fact]
        public void FileExistTest()
        {
            String path = @"D:\a\review-case-s22b1\review-case-s22b1\Sender-Test\bin\Release\netcoreapp3.1\TestFile\TestFile.csv";
            try
            {
                if (File.Exists("C:\\VARNIKA\\AssignmentBootcamp\\sample-review\\TestFile.csv"))
                    Program.ReadCSV(path);
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        [Fact]
        public void ReadFileTest()
        {
            String path = @"D:\a\review-case-s22b1\review-case-s22b1\Sender-Test\bin\Release\netcoreapp3.1\TestFile\TestFile.csv";
            String[] TestResult = File.ReadAllLines(path);
            String[] ReadCSVResult = Program.ReadCSV(path);
            bool areEqual = TestResult.SequenceEqual(ReadCSVResult);
            Assert.True(areEqual);
        }

        [Fact]
        public void PrintRowTest()
        {
            bool result;
            String path = @"D:\a\review-case-s22b1\review-case-s22b1\Sender-Test\bin\Release\netcoreapp3.1\TestFile\TestFile.csv";
            PrintCSV obj = new PrintCSV();
            String[] TestResult = File.ReadAllLines(path);
            foreach (string line in TestResult)
            {
                if (!string.IsNullOrEmpty(line) && line.Contains(','))
                {
                    string columns = line.Split(',')[1];
                    Console.WriteLine("{0}", columns);
                }
            }

            result = obj.PrintCSVRows(TestResult);
            Assert.True(result);
        }

        //[Fact]
        //public void PrintColTest()
        //{
        //    bool result2; bool TestResult;
        //    String path = @"C:\\VARNIKA\\TestFile.csv";
        //    String[] Lines = File.ReadAllLines(path);
        //    PrintCSV obj = new PrintCSV();
        //    foreach (var columns in Lines
        //        .Where(x => !string.IsNullOrEmpty(x))
        //        .Select(x => x.Split(','))
        //        .Where(x => x.Length > 1 && !string.IsNullOrEmpty(x[1]))
        //        .ToArray())
        //    {
        //        foreach (var column in columns)
        //        {
        //            TestResult = obj.PrintCSVCol(columns[1]);
        //            Console.Write("{0}", column);
        //            result2 = true;
        //        }
        //        Console.Write("\n");                
        //    }

        //    bool areEqual = result2.Equals(TestResult);
        //    Assert.True(areEqual);
        //}
    }
}
