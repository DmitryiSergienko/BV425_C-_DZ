using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public abstract class FactoryDocument
    {
        protected FactoryDocument() { }
        public abstract Document createDocument();
    }
}
