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
using System.Text.Json.Serialization;
using ws3dx.dslc.data;

namespace ws3dx.dslc.core.data.impl
{
   //------------------------------------------------------------------------------------------------
   // <summary>
   //
   // Example: [{"owner":"user2","organization":"MyOrganization","collabspace":"My Collaboration 
   // Space","id":"F718B05686760000926EEB5BE7400900","Status":200},{"owner":"user2","organization":"MyOrganization","collabspace":"My 
   // Collaboration Space","id":"F718B05686760000988EEB5BE7400900","Status":400,"ErrorReport":{"errorMessage":"Insufficient 
   // rights to transfer."}}]
   //
   // </summary>
   //------------------------------------------------------------------------------------------------
   public class TransferOutputPartialSuccess : ITransferOutputPartialSuccess
   {
      [JsonPropertyName("results")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public IList<ITransferOutputPartialSuccessResult> Results { get; set; }
   }
}