using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKaspersky
{
    class HtmlProcess : AbsrtactFileProcessor
    {
        protected override string GetFormat() => ".html";

        protected override void StartWork(string fileName)
        {
            Console.WriteLine("Работа с HTML файлом.");
        }
    }
}
