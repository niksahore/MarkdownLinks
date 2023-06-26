using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace MarkdownLink
{
    public class NodeEdgeCreator
    {
        #region Private Fields

        private IMarkdownFileParser _markdownFileParser;
        private XmlDocument _markdownXmlDocument;
        private XmlElement _rootElement;
        private string _rootDirectory;

        #endregion

        #region Properties

        public XmlDocument MarkdownXmlDocument
        {
            get
            {
                return _markdownXmlDocument;
            }
            set
            {
                _markdownXmlDocument = value;
            }
        }

        public string RootDirectory
        {
            get
            {
                return _rootDirectory;
            }
            set
            {
                _rootDirectory = value;
            }
        }

        public XmlElement RootElement
        {
            get
            {
                return _rootElement;
            }
            set
            {
                _rootElement = value;
            }
        }

        #endregion

        public NodeEdgeCreator()
        {
            _markdownFileParser = new MarkdownFileParser();
            _markdownXmlDocument = new XmlDocument();
            _rootElement = _markdownXmlDocument.CreateElement("Edges");
        }

        public IEnumerable<Node> CreateSourceNodes()
        {
            return Directory.GetFiles(_rootDirectory, "*.md", SearchOption.AllDirectories).Select(md => CreateNode(md));
        }

        public IEnumerable<Node> CreateTargetNodes(Node sourceNode)
        {
            return _markdownFileParser.ParseMarkdownFile(sourceNode.File).Select(md => CreateNode(md));
        }

        public Node CreateNode(string file)
        {
            var node = new Node
            {
                File = file
            };
            return node;
        }

        public Edge CreateEdge(Node source, Node target)
        {
            var edge = new Edge
            {
                Source = source,
                Target = target
            };
            return edge;
        }

        public XmlElement CreateEdgeElement(Edge edge)
        {
            var xmlElementEdge = _markdownXmlDocument.CreateElement("Edge");
            xmlElementEdge.SetAttribute("Source", edge.Source.File);
            xmlElementEdge.SetAttribute("Target", edge.Target.File);
            return xmlElementEdge;
        }
    }
}
