using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.Service
{
    internal class ReadOnlyDocument: Document
    {
        private string date;
        private string path;

        public ReadOnlyDocument(string path): base(path)
        {}
    }
}
