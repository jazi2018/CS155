using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Lab1
{
    internal class Document
    {
        private string text;

        public Document() { text = ""; }
        public Document(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return text;
        }

        public void setText(string text) {  this.text = text; }
    }
}
