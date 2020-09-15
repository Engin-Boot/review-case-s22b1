using System.Collections.Generic;
using Receiver;
using Xunit;

namespace Receiver_Test
{
    public class UnitTestOfFileOperation
    {
        [Fact]
        public void CheckForRightFileInsertion()
        {
            FileOperation fileOperation = new FileOperation();
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();
            keyValuePairs.Add("format", 2);
            keyValuePairs.Add("remove", 1);
            keyValuePairs.Add("void", 2);
            Assert.True(fileOperation.WriteWordAndItsCount(keyValuePairs));
        }

        [Fact]
        public void CheckForWrongFileInsertion()
        {
            FileOperation fileOperation = new FileOperation();
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();
            keyValuePairs.Add("format", 2);
            keyValuePairs.Add("remove", 1);
            keyValuePairs.Add("void", 2);
            Assert.False(fileOperation.WriteWordAndItsCount(keyValuePairs) == false);
        }

    }
}
