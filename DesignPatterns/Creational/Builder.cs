using System;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// A client representing the Builder design pattern by creating different types of documents
    /// which contain headers and paragraphs, namely Markdown or Html documents.
    ///
    /// https://en.wikipedia.org/wiki/Builder_pattern
    /// </summary>
    public class BuilderClient
    {
        private const string Title1 = "My First Title";
        private const string Paragraph1 = "My First Paragraph";
        private const string Title2 = "My Second Title";

        private readonly string _newline = Environment.NewLine;
        
        [Fact]
        public void TestHtmlDocumentBuilder()
        {
            var builder = new HtmlDocumentBuilder();
            builder.AddHeader(Title1)
                .AddParagraph(Paragraph1)
                .AddHeader(Title2);
            var document = builder.Build();
            Assert.Equal("HTML", document.DocumentType);
            Assert.Equal($"<h1>{Title1}</h1>{_newline}<p>{Paragraph1}</p>{_newline}<h1>{Title2}</h1>{_newline}", document.FormattedDocument);
        }

        [Fact]
        public void TestMarkdownDocumentBuilder()
        {
            var builder = new MarkdownDocumentBuilder();
            builder.AddHeader(Title1)
                .AddParagraph(Paragraph1)
                .AddHeader(Title2);
            var document = builder.Build();
            Assert.Equal("MD", document.DocumentType);
            Assert.Equal($"# {Title1}{_newline}{_newline}{Paragraph1}{_newline}{_newline}# {Title2}{_newline}{_newline}", document.FormattedDocument);
        }
    }
    
    
    public class Document
    {
        public string DocumentType;
        public string FormattedDocument;

        public Document(string formattedDocument, string documentType)
        {
            FormattedDocument = formattedDocument;
            DocumentType = documentType;
        }
    }
    
    
    public interface IDocumentBuilder
    {
        /// <summary>
        /// Adds a header to the Document
        /// </summary>
        /// <param name="headerText">Text of the header being added</param>
        /// <returns><see cref="IDocumentBuilder"/></returns>
        public IDocumentBuilder AddHeader(string headerText);

        /// <summary>
        /// Adds a paragraph with the specified text to the Document
        /// </summary>
        /// <param name="paragraphText">Text of the paragraph being added</param>
        /// <returns><see cref="IDocumentBuilder"/></returns>
        public IDocumentBuilder AddParagraph(string paragraphText);

        /// <summary>
        /// Builds a Document
        /// </summary>
        /// <returns><see cref="Document"/></returns>
        public Document Build();
    }
    
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