using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudicialDepartamentApp.Model
{
    public class Document
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string DocumentType { get; set; }
        public byte[] BinaryFile { get; set; } 
    }
}
