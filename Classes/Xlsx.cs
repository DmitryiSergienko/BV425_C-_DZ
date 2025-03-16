using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    class Xlsx : Document
    {
        public Xlsx() : base() { }
        public override void printDocument()
        {
            Console.WriteLine("Контент документа Xlsx...");
            Console.WriteLine(_title + "\n" + _header + "\n" + _body + "\n" + _footer + "\n");
        }
    }
}
