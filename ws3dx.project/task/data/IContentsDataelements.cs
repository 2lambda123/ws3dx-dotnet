//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2022 Dassault Systèmes - CPE EMED
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify,
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished
// to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
// BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//------------------------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace ws3dx.project.task.data
{
   public interface IContentsDataelements
   {
      public string Name { get; set; }

      public string Revision { get; set; }

      public string Title { get; set; }

      public string Synopsis { get; set; }

      public string Firstname { get; set; }

      public string Lastname { get; set; }

      public string Fullname { get; set; }

      public string ObjectId { get; set; }

      public string Policy { get; set; }

      public string StateNLS { get; set; }

      public string TypeNLS { get; set; }

      public string CollabSpace { get; set; }

      public string OwnerFullname { get; set; }

      public IList<string> Hasfiles { get; set; }

      public IList<string> FileExtension { get; set; }
   }
}