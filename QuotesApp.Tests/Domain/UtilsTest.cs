using System;
using Xunit;
using QuotesApp.Domain.Utils;

namespace QuotesApp.Tests.Domain
{
    public class UtilsTest
    {
        [Theory]
        [InlineData("My User Name   ")]
        [InlineData(" Key 1424")]
        [InlineData(" user325 ")]
        public void ItShouldTrimAllWhitespace(string text)
        {
            Assert.DoesNotContain(" ", text.RemoveAllWhitespace());
        }
    }
}
