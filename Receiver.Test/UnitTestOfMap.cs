using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Receiver.Test
{
    [TestClass]
    public class UnitTestOfMap
    {
        [TestMethod]
        public void CheckForInsertionOfWordCount()
        {
            MapOpeartion mapOpeartion = new MapOpeartion();
            List<string> words = new List<string> { "function", "remove", "void", "void", "function" };
            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();
            SortedDictionary<string, int> keyValuePairsExpected = new SortedDictionary<string, int>();
            keyValuePairsExpected.Add("function", 2);
            keyValuePairsExpected.Add("remove", 1);
            keyValuePairsExpected.Add("void", 2);
            keyValuePairs = mapOpeartion.InsertWordsAndCount(keyValuePairs, words);
            Assert.IsTrue(keyValuePairsExpected.SequenceEqual(keyValuePairs));

        }
    }
}
