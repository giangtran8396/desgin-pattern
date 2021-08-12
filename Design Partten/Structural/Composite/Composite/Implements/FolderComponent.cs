using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite.Implements
{
    public class FolderComponent : IFileComponent
    {
        List<IFileComponent> files { get; set; }
        public string folderName { get; set; }

        public FolderComponent(string name, IFileComponent[] arr)
        {
            this.folderName = name;
            this.files = arr.ToList();
        }

        public IFileComponent Excucte()
        {
            Console.WriteLine("Folder Name :" + this.folderName);
            this.files.ForEach(x => x.Excucte());
            return this;
        }
    }
}
