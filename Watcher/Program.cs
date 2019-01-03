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
            string sourceFile = e.FullPath;
            string destinationFile = @"F:\\" + e.Name;

            // To move a file or folder to a new location:
            System.IO.File.Move(sourceFile, destinationFile);

            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }
    }
}