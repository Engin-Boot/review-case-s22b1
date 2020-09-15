using Xunit;
using System.IO;
using System;

namespace Sender_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            try
            {
                if (File.Exists("C:\\VARNIKA\\Test.csv"))
                    return; // indicates success
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }
    }  
}
