using MarkdownLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
            var rootDirectory = @"C:\Nikhil\Learning\MarkdownGraph\Planion\MarkdownGraphTest\Sample";

            var result = _markdown.GetLinks(rootDirectory);

            Assert.Equal("Development", result.FirstChild.ChildNodes.Item(4).Attributes["Target"].Value);
        }
    }
}
