using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        public int blah = 0;
        public int hello = 0;
        private string language;
        // Constructor

        public PrintStuff()
        {
            language = "EN";
        }
        public PrintStuff(string temp) 
        {
            language = temp;
        }
        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }

            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }
        }
    }
}
