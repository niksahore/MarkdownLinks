using System.Xml;

namespace MarkdownLink
{
    public interface IFormatGenerator
    {
        XmlDocument Generate(XmlDocument xmlDocument);
    }
}
