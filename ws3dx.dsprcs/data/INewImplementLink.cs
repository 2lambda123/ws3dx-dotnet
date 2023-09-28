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
using ws3dx.dsmfg.data;

namespace ws3dx.dsprcs.data
{
   public interface INewImplementLink
   {
      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Pass true for Scope link creation. Example: false
      //
      // </summary>
      //----------------------------------------------------------------
      public bool? IsScope { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Occurrence path for the related process operation instance.
      //
      // </summary>
      //----------------------------------------------------------------
      public IList<ISpecifiedOccurrence> OperationOccurrence { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Occurrence path for the related manufacturing item instance that the operation is 
      // acting upon.
      //
      // </summary>
      //----------------------------------------------------------------
      public IList<ISpecifiedOccurrence> ItemOccurrence { get; set; }

      public IItemSpecificationAttributes Attributes { get; set; }
   }
}