using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PEA_1.Utility
{
    public class SourceFolder
    {
        // Zmodyfikowana klasa z mojego innego programu, znajduje wszystkie potrzebne pliki (tutaj testowe .txt) i je przechowuje.

        /// <summary>
        ///     List of all the files.
        /// </summary>
        public List<string> FilePaths { get; set; }

        public List<string> Filenames { get; set; }

        public string FolderPath { get; set; }

        /// <summary>
        ///     Class constructor.
        /// </summary>
        public SourceFolder()
        {
            FolderPath = AppDomain.CurrentDomain.BaseDirectory;
            //ProcessDirectory();
        }

        /// <summary>
        ///     Populates FilePaths with all the files inside the directory then removes ones that have incorrect extensions.
        /// </summary>
        public void ProcessDirectory()
        {
            FilePaths = Directory.GetFiles(FolderPath).ToList();
            for (int i = FilePaths.Count - 1; i > -1; i--)
            {
                if (Path.GetExtension(FilePaths[i]) != ".txt" || !FilePaths[i].Contains("tsp"))
                {
                    FilePaths.RemoveAt(i);
                }
            }
        }

        /// <summary>
        ///     Fills another list with filenames only, needed for drop list display.
        /// </summary>
        public void PopulateFilenameList()
        {
            Filenames = new List<string>();
            foreach (string path in FilePaths)
            {
                Filenames.Add(Path.GetFileName(path));
            }
        }
    }
}