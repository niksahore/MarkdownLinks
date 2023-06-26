using System.Collections.Generic;

namespace MarkdownGraph
{
    public interface IMarkdownFileParser
    {
        List<string> ParseMarkdownFile(string filePath);
    }
}
