using Composite.Implements;
using Composite.Interfaces;
using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileComponent file1 = new FileLeaf("file 1");
            IFileComponent file2 = new FileLeaf("file 2");
            IFileComponent file3 = new FileLeaf("file 3");
            IFileComponent folder1 = new FolderComponent("Folder 1", new IFileComponent[] { file1,file2,file3 });
            IFileComponent file4 = new FileLeaf("file 4");
            IFileComponent file5 = new FileLeaf("file 5");
            IFileComponent folder2 = new FolderComponent("Folder 2", new IFileComponent[] { file4, file5 ,folder1  });
            folder2.Excucte();
            Console.ReadLine();
        }
    }
}
