using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKaspersky
{
    class TextProcess : AbsrtactFileProcessor
    {
        protected override string GetFormat() => ".txt";

        protected override void StartWork(string fileName)
        {
            Console.WriteLine("Работа с txt файлом.");
        }
    }
}
