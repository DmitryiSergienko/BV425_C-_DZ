using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    class FactoryPptx : FactoryDocument
    {
        public FactoryPptx() : base() { }
        public override Document createDocument()
        {
            Pptx pptx = new Pptx();
            pptx
                .Title("Title")
                .Header("Header")
                .Body("Body")
                .Footer("Footer");
            Console.WriteLine("Документ Pptx создан!");
            return pptx;
        }
    }
}
