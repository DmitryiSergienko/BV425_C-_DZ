using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public abstract class Document
    {
        protected string _title = "Default";
        protected string _header = "Default";
        protected string _body = "Default";
        protected string _footer = "Default";

        protected Document() { }
        public abstract void printDocument();
        public Document Title(string title) { _title = title; { return this; } }
        public Document Header(string header) { _header = header; { return this; } }
        public Document Body(string body) { _body = body; { return this; } }
        public Document Footer(string footer) { _footer = footer; { return this; } }
    }
}