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
using System.Threading.Tasks;
using ws3dx.authentication.data;
using ws3dx.core.service;
using ws3dx.dslc.data;

namespace ws3dx.dslc.core.service
{
   // SDK Service
   public class DuplicateService : EnoviaBaseService
   {
      private const string BASE_RESOURCE = "/resources/v1/modeler/dslc/";

      public DuplicateService(string enoviaService, IPassportAuthentication passport) : base(enoviaService, passport)
      {
      }

      protected string GetBaseResource()
      {
         return BASE_RESOURCE;
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (POST) duplicate
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Duplicate a list of objects. The request will be rejected if the total number of 
      // objects exceeds 100. Summary: Duplicate objects
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IEnumerable<IDuplicate>> Duplicate(IDuplicateInput request)
      {
         string resourceURI = $"{GetBaseResource()}duplicate";

         return await PostCollectionFromResponseResultsProperty<IDuplicate, IDuplicateInput>(resourceURI, request);
      }
   }
}