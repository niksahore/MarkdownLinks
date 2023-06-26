using System.IO;
using System.Xml;

namespace MarkdownLink
{
    public interface IFormatter
    {
        XmlDocument ConvertFormat(XmlDocument xmlDocument, string formatType);
    }
}
