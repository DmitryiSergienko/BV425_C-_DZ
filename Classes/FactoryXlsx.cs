using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    class FactoryXlsx : FactoryDocument
    {
        public FactoryXlsx() : base() { }
        public override Document createDocument()
        {
            Xlsx xlsx = new Xlsx();
            xlsx
                .Title("Title")
                .Header("Header")
                .Body("Body")
                .Footer("Footer");
            Console.WriteLine("Документ Xlsx создан!");
            return xlsx;
        }
    }
}
