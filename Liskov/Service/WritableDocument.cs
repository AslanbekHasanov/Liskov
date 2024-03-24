using System;
using System.IO;

namespace Liskov.Service
{
    internal class WritableDocument: Document
    {
        public WritableDocument(string path): base(path)
        {}

        public void Save()
        {
            this.date += DateTime.Now.ToString();
            File.WriteAllText(this.path, this.date);
        }
    }
}
