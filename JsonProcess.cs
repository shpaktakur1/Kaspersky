using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKaspersky
{
    class JsonProcess : AbsrtactFileProcessor
    {
        protected override string GetFormat() => ".json";
        protected override void StartWork(string fileName)
        {
            Console.WriteLine("Работа с файлом JSON.");
        }
    }
}
