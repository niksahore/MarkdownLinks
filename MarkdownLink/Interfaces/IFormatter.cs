using System.IO;
using System.Xml;

namespace MarkdownLink
{
    public interface IFormatter
    {
        string ConvertFormat(XmlDocument xmlDocument, string formatType);
    }
}
