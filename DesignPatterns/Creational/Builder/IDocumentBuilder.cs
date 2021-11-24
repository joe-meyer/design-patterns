namespace DesignPatterns.Behavioral.Builder
{
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
}