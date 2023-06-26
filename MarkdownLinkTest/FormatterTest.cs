using MarkdownLink;
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
            var rootDirectory = @"../debug/Sample";
            
            var xmlDocument = _markdown.GetLinks(rootDirectory);
            var result = _formatter.ConvertFormat(xmlDocument, formatType);
        }
    }
}
