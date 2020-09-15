using Xunit;
using System.IO;
using System;
using Sender;

namespace Sender_Test
{
    public class UnitTest1
    {
        [Fact]
        public void FileExistTest()
        {
            String path = @"C:\\VARNIKA\\Test.csv";
            try
            {
                if (File.Exists("C:\\VARNIKA\\Test.csv"))
                    Program.ReadCSV(path); // indicates success
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }                
    }  
}
