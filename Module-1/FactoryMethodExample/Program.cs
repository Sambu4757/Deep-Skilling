using System;

class Program
{
    static void Main()
    {
        DocumentFactory factory;

        factory = new WordFactory();
        IDocument doc1 = factory.CreateDocument();
        doc1.Open();

        factory = new PdfFactory();
        IDocument doc2 = factory.CreateDocument();
        doc2.Open();

        factory = new ExcelFactory();
        IDocument doc3 = factory.CreateDocument();
        doc3.Open();
    }
}