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
        }

        public void SaveAll()
        {
            foreach(var document in writableDocuments)
            {
                document.Save();
            }
        }

        public void AddDocument(Document document)=>
            this.documents.Add(document);

        public void AddDocumnet(WritableDocument writableDocument)=>
            this.writableDocuments.Add(writableDocument);
    }
}
