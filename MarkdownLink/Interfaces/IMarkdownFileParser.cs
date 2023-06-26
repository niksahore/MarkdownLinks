using System.Collections.Generic;

namespace MarkdownLink
{
    public interface IMarkdownFileParser
    {
        List<string> ParseMarkdownFile(string filePath);
    }
}
