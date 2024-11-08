using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Lab1
{
    internal class File : Document
    {
        private string pathname;

        public File() :base() { pathname = ""; }
        public File(string pathname, string text) : base(text)
        {
            this.pathname = pathname;
        }

        public void setPathname(string pathname) { this.pathname = pathname; }
        public string getPathname() { return this.pathname; }

        public new string ToString()
        {
            return $"Pathname: {this.pathname}\n" +
                $"File contents: {base.ToString()}";
        }
    }
}
