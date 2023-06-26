using MarkdownLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarkdownLinkTest
{
    public class FormatterTest
    {
        private Markdown _markdown;
        private Formatter _formatter;

        public FormatterTest()
        {
            _markdown = new Markdown();
            _formatter = new Formatter();
        }

        [Theory]
        [InlineData("dgml")]
        [InlineData("dot")]
        [InlineData("graphml")]
        public void ConvertFormat_ReturnsXml(string formatType)
        {
            var rootDirectory = @"C:\Nikhil\Learning\MarkdownGraph\Planion\MarkdownGraphTest\Sample";

            var xmlDocument = _markdown.GetLinks(rootDirectory);
            var result = _formatter.ConvertFormat(xmlDocument, formatType);
            var test = result;

            //Assert.Equal("Development", result.FirstChild.ChildNodes.Item(4).Attributes["Target"].Value);
        }
    }
}
