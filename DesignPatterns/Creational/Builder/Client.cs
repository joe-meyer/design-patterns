using System;
using Xunit;

namespace DesignPatterns.Behavioral.Builder
{
    /// <summary>
    /// A client representing the Builder design pattern by creating different types of documents
    /// which contain headers and paragraphs, namely Markdown or Html documents.
    ///
    /// https://en.wikipedia.org/wiki/Builder_pattern
    /// </summary>
    public class Client
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
}