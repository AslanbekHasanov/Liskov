using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Liskov.Service
{
    internal class Project
    {
        private List<Document> documents;
        private List<WritableDocument> writableDocuments;

        public Project()
        {
            this.documents = new List<Document>();
            this.writableDocuments = new List<WritableDocument>();
        }

        public void OpenAll()
        {
            foreach (var document in documents) 
            {
                document.Open();
            }

            foreach (var document in writableDocuments)
            {
                document.Open();
            }
        }

        public void SaveAll()
        {
            foreach(var document in writableDocuments)
            {
                document.Save();
            }
        }
        public void AddDocument(WritableDocument writableDocument)
        {
            try
            {
                this.writableDocuments.Add(writableDocument);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to save read-only file. {ex.Message}");
            }
        }

        public void AddDocument(Document document)
        {
            try
            {
                this.documents.Add(document);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to save read-only file. {ex.Message}");
            }
        }

    }
}
