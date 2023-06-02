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
using System.Text.Json.Serialization;
using ws3dx.dseng.data;

namespace ws3dx.dseng.core.impl
{
   public class Expand : IExpand
   {
      //------------------------------------------------------------------------------------------------
      //<summary>
      //
      // Description: -1 for all level, and 1,2,3,.. for specific level Example: 1
      //
      //<summary>
      //------------------------------------------------------------------------------------------------
      [JsonPropertyName("expandDepth")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public int? ExpandDepth { get; set; }

      //------------------------------------------------------------------------------------------------
      //<summary>
      //
      // Description: true/false Example: true
      //
      //<summary>
      //------------------------------------------------------------------------------------------------
      [JsonPropertyName("withPath")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public bool? WithPath { get; set; }

      //------------------------------------------------------------------------------------------------
      //<summary>
      //
      // Description: inputType is not proper. Please check the Filter Specification here: Web Services 
      // and Events | 3DSpace | Advanced Filtering | The Public Filter Specification Example: {...}
      //
      //<summary>
      //------------------------------------------------------------------------------------------------
      [JsonPropertyName("filter")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string Filter { get; set; }
   }
}