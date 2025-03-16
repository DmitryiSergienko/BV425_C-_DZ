using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class FactoryDocx : FactoryDocument
    {
        public FactoryDocx() : base() { }
        public override Document createDocument() {
            Docx docx = new Docx();
            docx
                .Title("Title")
                .Header("Header")
                .Body("Body")
                .Footer("Footer");
            Console.WriteLine("Документ Docx создан!"); 
            return docx; 
        }
    }
}