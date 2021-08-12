using Composite.Interfaces;
using System;

namespace Composite.Implements
{
    class FileLeaf : IFileComponent
    {
        public string fileName { get; set; }

        public FileLeaf(string name)
        {
            this.fileName = name;
        }

        public IFileComponent Excucte()
        {
            Console.WriteLine("File name : " + fileName);
            return this;
        }
    }
}
