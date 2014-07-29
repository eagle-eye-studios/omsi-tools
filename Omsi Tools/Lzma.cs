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
using SevenZip;

namespace OmsiTools
{
    /// <summary>
    /// Helper class for easier use of the SevenZipSharp library.
    /// Does the instancing and settings stuff for you.
    /// </summary>
    public class Lzma
    {
        /// <summary>
        /// Compresses your files asynchronously.
        /// </summary>
        /// <param name="files">The list of files to compress (full paths)</param>
        /// <param name="outputFile">The output archive file (full path)</param>
        public static void Compress(List<string> files, string outputFile)
        {
            Compress(files, outputFile, null, null, null);
        }

        /// <summary>
        /// Compresses your files asynchronously
        /// </summary>
        /// <param name="files">The list of files to compress (full paths)</param>
        /// <param name="outputFile">The output archive file (full path)</param>
        /// <param name="compressionHandler">Function to call when the compression state changes. Hint: update your progress bar here!</param>
        /// <param name="fileCompressionStartedHandler">Function is called when a new file is starting to be compressed. Hint: Update your status text here!</param>
        /// <param name="compressionFinished">Function to call when everything is done.</param>
        public static void Compress(List<string> files, string outputFile, EventHandler<ProgressEventArgs> compressionHandler, EventHandler<FileNameEventArgs> fileCompressionStartedHandler, EventHandler<EventArgs> compressionFinished)
        {
            if (Environment.Is64BitProcess)
                SevenZipCompressor.SetLibraryPath(Path.GetFullPath("7z64.dll"));
            else
                SevenZipCompressor.SetLibraryPath(Path.GetFullPath("7z.dll"));
            SevenZipCompressor szc = new SevenZipCompressor();
            szc.PreserveDirectoryRoot = true;
            szc.CompressionMethod = CompressionMethod.Lzma2;
            szc.EncryptHeaders = true;
            szc.CompressionLevel = CompressionLevel.Ultra;

            if (compressionHandler != null)
                szc.Compressing += compressionHandler;
            if (fileCompressionStartedHandler != null)
                szc.FileCompressionStarted += fileCompressionStartedHandler;
            if (compressionFinished != null)
                szc.CompressionFinished += compressionFinished;

            szc.BeginCompressFiles(outputFile, files.ToArray());
        }

        /// <summary>
        /// Function to compress a single file
        /// </summary>
        /// <param name="file">The file to compress</param>
        /// <param name="outputFile">The output archive</param>
        public static void Compress(string file, string outputFile)
        {
            if (Environment.Is64BitProcess)
                SevenZipCompressor.SetLibraryPath(Path.GetFullPath("7z64.dll"));
            else
                SevenZipCompressor.SetLibraryPath(Path.GetFullPath("7z.dll"));
            SevenZipCompressor szc = new SevenZipCompressor();
            szc.CompressFiles(outputFile, file);
        }

        /// <summary>
        /// Extracts a 7zip archive to the specified output directory. UNFINISHED!
        /// </summary>
        /// <param name="inputFile">The archive to extract (full path, please!)</param>
        /// <param name="outputDir">The path to extract the archive to (also full path, please!)</param>
        public static void Extract(string inputFile, string outputDir)
        {
            if (Environment.Is64BitProcess)
                SevenZip.SevenZipExtractor.SetLibraryPath(Path.GetFullPath("7z64.dll"));
            else
                SevenZip.SevenZipExtractor.SetLibraryPath(Path.GetFullPath("7z.dll"));
            SevenZip.SevenZipExtractor e = new SevenZip.SevenZipExtractor(inputFile);
            e.PreserveDirectoryStructure = true;
            e.ExtractArchive(outputDir);
        }
    }
}
