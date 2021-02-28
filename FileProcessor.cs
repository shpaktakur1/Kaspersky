using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKaspersky
{
    class FileProcessor
    {
        public AbsrtactFileProcessor fileProcessor;

        public FileProcessor(AbsrtactFileProcessor fileProcessor) => this.fileProcessor = fileProcessor;

        public void ProcessFile(string fileName)
        {
            fileProcessor.ProcessFile(fileName);
        }

    }


}
