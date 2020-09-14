using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Receiver.Test
{
    public class UnitTestOfComment
    {
        [Fact]
        public void CheckForRightDictionary()
        {
            CommentSplitter commentSplitter = new CommentSplitter();
            SortedDictionary<string, int> wordCount = new SortedDictionary<string, int>();
            string comment = "void function remove function void";
            SortedDictionary<string, int> keyValuePairsExpected = new SortedDictionary<string, int>();
            keyValuePairsExpected.Add("function", 2);
            keyValuePairsExpected.Add("remove", 1);
            keyValuePairsExpected.Add("void", 2);
            wordCount = commentSplitter.SplitCommentsIntoWords(wordCount, comment);
            Assert.True(keyValuePairsExpected.SequenceEqual(wordCount));
        }
    }
}
