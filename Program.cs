using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKaspersky
{
    class Program
    {
        static void Main(string[] args)
        {
            FileProcessor fp = new FileProcessor(new HtmlProcess());
            fp.ProcessFile(@"C:\Users\PRO100VANO\source\repos\TestKaspersky\TestKaspersky\Test.html");

            fp.fileProcessor = new TextProcess();
            fp.ProcessFile(@"C:\Users\PRO100VANO\source\repos\TestKaspersky\TestKaspersky\Test.txt");

            fp.fileProcessor = new JsonProcess();
            fp.ProcessFile(@"C:\Users\PRO100VANO\source\repos\TestKaspersky\TestKaspersky\Test.json");
        }
    }
}
