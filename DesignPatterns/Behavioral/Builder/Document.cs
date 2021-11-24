namespace DesignPatterns.Behavioral.Builder
{
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
}