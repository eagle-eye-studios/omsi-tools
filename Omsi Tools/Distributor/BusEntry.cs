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
using System.Linq;

namespace OmsiTools.Distributor
{
    public class BusEntry
    {
        public string Name { get; internal set; }
        public string Path { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
