using System.Text;

namespace DesignPatterns.Behavioral.Builder
{
    public class HtmlDocumentBuilder : IDocumentBuilder
    {
        private readonly StringBuilder _documentText = new StringBuilder();
        
        public IDocumentBuilder AddHeader(string headerText)
        {
            _documentText.AppendLine($"<h1>{headerText}</h1>");
            return this;
        }

        public IDocumentBuilder AddParagraph(string paragraphText)
        {
            _documentText.AppendLine($"<p>{paragraphText}</p>");
            return this;
        }
        
        public Document Build()
        {
            return new Document(_documentText.ToString(), "HTML");
        }
    }
}