using MarkdownLink;
using Xunit;

namespace MarkdownLinkTest
{
    public class MarkdownTest
    {
        private Markdown _markdown;

        public MarkdownTest()
        {
            _markdown = new Markdown();
        }

        [Fact]
        public void MarkdownLinks_ReturnsXmlDocument()
        {
            var rootDirectory = @"../debug/Sample";

            var result = _markdown.GetLinks(rootDirectory);

            Assert.Equal("Development", result.FirstChild.ChildNodes.Item(4).Attributes["Target"].Value);
        }
    }
}
