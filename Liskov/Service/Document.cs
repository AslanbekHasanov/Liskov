using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.Service
{
    internal class Document
    {
        private string date = "";
        private readonly string path;

        public Document(string path)
        {
            this.path = path;
            this.CheckExsist();
        }

        public void Open()
        {
            date = File.ReadAllText(path);
        }

        private void CheckExsist()
        {
            if (File.Exists(path) is false)
            {
                File.Create(path).Close();
            }
        }

    }
}
