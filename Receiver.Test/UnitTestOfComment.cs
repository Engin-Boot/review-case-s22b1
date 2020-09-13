using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Receiver.Test
{
    [TestClass]
    public class UnitTestOfComment
    {
        [TestMethod]
        public void CheckForRightDictionary()
        {
            CommentSplitter commentSplitter = new CommentSplitter();
            SortedDictionary<string, int> wordCount = new SortedDictionary<string, int>();
            string comment = "void function remove function void";
            SortedDictionary<string, int> keyValuePairsExpected = new SortedDictionary<string, int>();
            keyValuePairsExpected.Add("function", 2);
            keyValuePairsExpected.Add("remove", 1);
            keyValuePairsExpected.Add("void", 2);
            wordCount = commentSplitter.SplitCommentsIntoWords(wordCount,comment);
            Assert.IsTrue(keyValuePairsExpected.SequenceEqual(wordCount));
        }
    }
}
