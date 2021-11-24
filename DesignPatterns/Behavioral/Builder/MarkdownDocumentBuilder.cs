using System.Text;

namespace DesignPatterns.Behavioral.Builder
{
    public class MarkdownDocumentBuilder : IDocumentBuilder
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();
        
        public IDocumentBuilder AddHeader(string headerText)
        {
            _stringBuilder.AppendLine($"# {headerText}");
            _stringBuilder.AppendLine();
            return this;
        }

        public IDocumentBuilder AddParagraph(string paragraphText)
        {
            _stringBuilder.AppendLine($"{paragraphText}");
            _stringBuilder.AppendLine();
            return this;
        }

        public Document Build()
        {
            return new Document(_stringBuilder.ToString(), "MD");
        }
    }
}