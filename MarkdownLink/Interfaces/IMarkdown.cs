using System.Xml;

namespace MarkdownLink
{
    public interface IMarkdown
    {
        /// <summary>
        /// Takes root directory as input for all md files.
        /// And returns Xml document with all md files Links.
        /// </summary>
        /// <param name="rootDirectory"></param>
        /// <returns></returns>
        XmlDocument GetLinks(string rootDirectory);
    }
}
