using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Urls
    {
        public string Url { set; get; }
        public bool OK { set; get; }
        public string message { set; get; }
        public Urls() { }
        public override string ToString()
        {
            return Url + "   " + message+"vanlksvnlka";
        }
    }
}
