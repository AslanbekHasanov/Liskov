using System;
using System.IO;
using System.Linq;

namespace Liskov.Service
{
    internal class WritableDocument: Document
    {
        public WritableDocument(string path): base(path)
        {}

        public void Save()
        {
            try
            {
                this.date += DateTime.Now.ToString();
                File.AppendAllText(this.path, this.date);
                Console.WriteLine(date);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Unable to save read-only file.");
                Console.ResetColor();
            }
        }
    }
}
