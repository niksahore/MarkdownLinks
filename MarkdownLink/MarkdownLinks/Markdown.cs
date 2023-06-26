using System.Linq;
using System.Xml;

namespace MarkdownLink
{
    public class Markdown : IMarkdown
    {
        private NodeEdgeCreator _nodeEdgeCreator;

        public Markdown()
        {
            _nodeEdgeCreator = new NodeEdgeCreator();
        }

        public XmlDocument GetLinks(string rootDirectory)
        {
            _nodeEdgeCreator.RootDirectory = rootDirectory;
            ProcessMarkdownFiles();
            return _nodeEdgeCreator.MarkdownXmlDocument;
        }

        private void ProcessMarkdownFiles()
        {
            var sourceNodes = _nodeEdgeCreator.CreateSourceNodes();

            foreach (var sourceNode in sourceNodes)
            {
                var targetNodes = _nodeEdgeCreator.CreateTargetNodes(sourceNode);
                if (targetNodes.Any())
                {
                    foreach (var targetNode in targetNodes)
                    {
                        var edge = _nodeEdgeCreator.CreateEdge(sourceNode, targetNode);
                        var edgeElement = _nodeEdgeCreator.CreateEdgeElement(edge);
                        _nodeEdgeCreator.RootElement.AppendChild(edgeElement);
                    }
                }
            }
            _nodeEdgeCreator.MarkdownXmlDocument.AppendChild(_nodeEdgeCreator.RootElement);
        }
    }
}
