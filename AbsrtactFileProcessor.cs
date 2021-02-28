using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKaspersky
{
    abstract class AbsrtactFileProcessor
    {
        public void ProcessFile(string fileName)
        {
            if (File.Exists(fileName) && Path.GetExtension(fileName).Contains(GetFormat()))
                StartWork(fileName);
            else
                Console.WriteLine("Некорректный формат. Файла не существует.");

        }

       
        protected abstract void StartWork(string fileName);
        protected abstract string GetFormat();
    }
}
