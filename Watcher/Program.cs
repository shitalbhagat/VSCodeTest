using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Watcher
{
    public class Program
    {
        public void FileChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }
    }
}