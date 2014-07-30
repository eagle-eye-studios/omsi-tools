/*  This file is part of the "OMSI Tools" project. 
 *
 *  Authors: Florian Vick <florian@eagle-eye-studios.net> 
 *  Find the project at https://github.com/vickfl/omsi-tools/
 *
 *  OMSI Tools is licensed under the MIT License:
 * 
 *	Copyright (c) 2014 Eagle Eye Studios, Florian Vick
 *
 *	Permission is hereby granted, free of charge, to any person obtaining a copy
 *	of this software and associated documentation files (the "Software"), to deal
 *	in the Software without restriction, including without limitation the rights
 *	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *	copies of the Software, and to permit persons to whom the Software is
 *	furnished to do so, subject to the following conditions:
 *
 *	The above copyright notice and this permission notice shall be included in
 *	all copies or substantial portions of the Software.
 *
 *	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 *	THE SOFTWARE.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace OmsiTools.Backup
{
    /// <summary>
    /// Class representing a backup.
    /// </summary>
    public class Backup
    {
        #region Properties
        /// <summary>
        /// The date the backup was created
        /// </summary>
        public DateTime Date { get; internal set; }
        /// <summary>
        /// The directory the backup contains
        /// </summary>
        public string Directory { get; internal set; }
        /// <summary>
        /// The size of this backup
        /// </summary>
        public double Size { get; internal set; }
        /// <summary>
        /// The unique identifier for the corresponding archive file
        /// </summary>
        public string ArchiveID { get; internal set; }
        /// <summary>
        /// List containing all the files of the backup.
        /// </summary>
        public List<String> Files { get; internal set; }
        /// <summary>
        /// Current Progress
        /// </summary>
        public int Progress { get; internal set; }

        #endregion

        #region Fields
        private bool finished = true;
        #endregion

        public Backup()
        {
            Files = new List<string>();
            ArchiveID = Guid.NewGuid().ToString();
        }

        #region Static Methods
        /// <summary>
        /// Creates and returns a new instance of the backup class with the specified parameters
        /// </summary>
        /// <param name="directory">Directory the backup operation should be runned on</param>
        public static Backup Create(string directory)
        {
            var ret = new Backup();
            ret.Date = DateTime.Now;
            ret.Directory = directory;

            var targetPath = Path.Combine(Properties.Settings.Default.OmsiPath, directory);
            if (directory == "OMSI 2")
                targetPath = Properties.Settings.Default.OmsiPath;
            DirectoryInfo di = new DirectoryInfo(targetPath);
            var fa = di.GetFiles("*", SearchOption.AllDirectories);
            foreach (var f in fa)
            {
                ret.Files.Add((f.FullName).Replace(targetPath + "\\", ""));
                ret.Size += f.Length;
            }
            return ret;
        }

        /// <summary>
        /// Creates and returns a new instance of the backup class with the specified parameters
        /// </summary>
        /// <param name="files">The files that should be included in the backup. Must be relative to the OMSI root</param>
        /// <returns>Backup instance</returns>
        public static Backup Create(List<string> files)
        {
            var ret = new Backup();
            ret.Date = DateTime.Now;
            ret.Directory = CommonRoot(files).Replace(Properties.Settings.Default.OmsiPath, "");
            if (!String.IsNullOrEmpty(ret.Directory))
                ret.Directory = ret.Directory.Remove(0, 1); // remove leading backslash

            var targetPath = Path.Combine(Properties.Settings.Default.OmsiPath, ret.Directory);
            foreach (var file in files)
            {
                FileInfo fi = new FileInfo(file);
                ret.Files.Add((fi.FullName).Replace(targetPath + "\\", ""));
                ret.Size += fi.Length;
            }

            return ret;
        }

        /// <summary>
        /// Loads a backup info file from the specified path
        /// </summary>
        /// <param name="file">The target file to load</param>
        /// <returns>Backup instance</returns>
        public static Backup Load(string file)
        {
            var ret = new Backup();
            XElement e = XElement.Load(file);
            ret.Date = DateTime.Parse(e.Element("Date").Value);
            ret.Directory = e.Element("Directory").Value;
            ret.Size = Convert.ToDouble(e.Element("Size").Value);
            ret.ArchiveID = e.Element("ArchiveID").Value;
            foreach (var de in e.Element("Files").Elements())
            {
                if (de.Name != "File")
                    continue;
                ret.Files.Add(de.Value);
            }
            return ret;
        }

        /// <summary>
        /// Finds the common root of file names
        /// </summary>
        /// <param name="files">Array of file names</param>
        /// <returns>Common root</returns>
        private static string CommonRoot(ICollection<string> files)
        {
            var splittedFileNames = new List<string[]>(files.Count);
            splittedFileNames.AddRange(files.Select(fn => fn.Split(Path.DirectorySeparatorChar)));
            int minSplitLength = splittedFileNames[0].Length - 1;
            if (files.Count > 1)
            {
                for (int i = 1; i < files.Count; i++)
                {
                    if (minSplitLength > splittedFileNames[i].Length)
                    {
                        minSplitLength = splittedFileNames[i].Length;
                    }
                }
            }
            string res = "";
            for (int i = 0; i < minSplitLength; i++)
            {
                bool common = true;
                for (int j = 1; j < files.Count; j++)
                {
                    if (!(common &= splittedFileNames[j - 1][i] == splittedFileNames[j][i]))
                    {
                        break;
                    }
                }
                if (common)
                {
                    res += splittedFileNames[0][i] + Path.DirectorySeparatorChar;
                }
                else
                {
                    break;
                }
            }
            return res.Remove(res.Length-1, 1);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Performs the backup. Recommended to be called async.
        /// </summary>
        public void Perform()
        {
            string path = Path.Combine(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupDataDir), ArchiveID + ".backup");
            if (File.Exists(path))
                throw new Exception("File already exists:" + path);
            var files = new List<string>();
            var tp = (this.Directory == "OMSI 2") ? Properties.Settings.Default.OmsiPath : Path.Combine(Properties.Settings.Default.OmsiPath, Directory);
            foreach (var file in Files)
            {
                files.Add(Path.Combine(tp, file));
            }
            finished = false;
            Lzma.Compress(files, path, new EventHandler<SevenZip.ProgressEventArgs>(Working), null, new EventHandler<EventArgs>(Finished));
            while (!finished)
            {
                // twiddle thumbs
            }
        }

        private void Working(object sender, SevenZip.ProgressEventArgs args)
        {
            Progress = args.PercentDone;
        }

        private void Finished(object sender, EventArgs args)
        {
            finished = true;
        }

        /// <summary>
        /// Restores the backup to it's original place inside the OMSI 2 directory
        /// </summary>
        public void Restore()
        {
            string extractionDir;
            if (Directory != "OMSI 2")
                extractionDir = Path.Combine(Properties.Settings.Default.OmsiPath, Directory);
            else
                extractionDir = Properties.Settings.Default.OmsiPath;

            finished = false;
            Lzma.Extract(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupDataDir, ArchiveID + ".backup"), extractionDir, new EventHandler<SevenZip.ProgressEventArgs>(Working), new EventHandler<SevenZip.FileOverwriteEventArgs>(Overwrite), null, new EventHandler<EventArgs>(Finished));
            while (!finished)
            {
                // Twiddle thumbs
            }
        }

        private void Overwrite(object sender, SevenZip.FileOverwriteEventArgs args)
        {
            args.Cancel = false;
            Console.WriteLine("Overwriting existing file: " + args.FileName);
        }

        /// <summary>
        /// Saves the info to disk
        /// </summary>
        public void Save()
        {
            XElement s =
                 new XElement("Backup",
                    new XElement("Date", Date.ToString()),
                    new XElement("Directory", Directory.ToString()),
                    new XElement("Size", Size.ToString()),
                    new XElement("ArchiveID", ArchiveID.ToString())                    
            );
            XElement loop = new XElement("Files");
            foreach (var file in Files)
            {
                loop.Add(new XElement("File", file));
            }
            s.Add(loop);
            s.Save(Path.Combine(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupInfoDir), ArchiveID + ".xml"));
        }
        #endregion
    }
}
