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
        /// <summary>
        /// Sample usage of using a Builder implementation
        /// </summary>
        /// <returns><see cref="Document"/></returns>
        public Document GenerateDocument()
        {
            //var builder = new HtmlDocumentBuilder();
            var builder = new MarkdownDocumentBuilder(); 

            builder.AddHeader("My First Title")
                .AddParagraph("My First Paragraph")
                .AddHeader("My Second Title")
                .AddParagraph("My Second Paragraph");

            return builder.Build();
        }        
    }
}