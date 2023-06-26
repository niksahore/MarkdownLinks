using System.Xml;

namespace MarkdownLink
{
    public class Formatter : IFormatter
    {
        public string ConvertFormat(XmlDocument xmlDocument, string formatType)
        {
            if (string.IsNullOrEmpty(formatType))
            {
                return null;
            }
            formatType = formatType.ToLower();
            IFormatGenerator generator;
            switch (formatType)
            {
                case "dgml":
                    generator = new DgmlGenerator();
                    break;
                case "dot":
                    generator = new DotGenerator();
                    break;
                default:
                    generator = new DgmlGenerator();
                    break;
            }
            return generator?.Generate(xmlDocument);
        }
    }
}
