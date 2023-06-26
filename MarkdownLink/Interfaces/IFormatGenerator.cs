using System.Xml;

namespace MarkdownLink
{
    public interface IFormatGenerator
    {
        string Generate(XmlDocument xmlDocument);
    }
}
