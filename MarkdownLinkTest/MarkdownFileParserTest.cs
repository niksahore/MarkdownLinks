using MarkdownLink;
using System.Collections.Generic;
using Xunit;

namespace MarkdownLinkTest
{
    public class MarkdownFileParserTest
    {
        private MarkdownFileParser _markdownFileParser;
        public MarkdownFileParserTest()
        {
            _markdownFileParser = new MarkdownFileParser();
        }

        [Fact]
        public void MarkdownParser_ReturnsConnectedMdFiles()
        {
            var inputFile = @"../debug/Sample/ReadMe.md";

            var result = _markdownFileParser.ParseMarkdownFile(inputFile);

            var expectedMdFiles = new List<string> { "Basics", "Filters", "Hello", "Development" };
            Assert.Equal(expectedMdFiles, result);
        }
    }
}
