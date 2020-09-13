using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Receiver.Test
{
    [TestClass]
    public class UnitTestOfStringFormat
    {
        [TestMethod]
        public void CheckForInvalidStringWhenStringEndsWithInvalidCharacter()
        {
            FormatComment formatComment = new FormatComment();
            string testString = "hello@96";
            Assert.IsTrue(formatComment.RemoveInvalidCharacters(testString) == "hello");
        }
        
        [TestMethod]
        public void CheckForInvalidStringWhenStringStartsWithInvalidCharacter()
        {
            FormatComment formatComment = new FormatComment();
            string testString = "67,remove";
            Assert.IsTrue(formatComment.RemoveInvalidCharacters(testString) == "remove");

        }

        [TestMethod]
        public void CheckForInvalidStringWhenStringHasInvalidCharactersInBetween()
        {
            FormatComment formatComment = new FormatComment();
            string testString = "rem12}o{ve";
            Assert.IsTrue(formatComment.RemoveInvalidCharacters(testString) == "remove");

        }
    }
}
