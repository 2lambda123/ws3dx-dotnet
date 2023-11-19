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
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ws3dx.dsprcs.core.service;
using ws3dx.dsprcs.data;
using ws3dx.core.exception;

namespace NUnitTestProject
{
   public class MfgProcessInstanceService_MfgProcessInstance_UnitTests : MfgProcessInstanceServiceTestsSetup
   {
      [TestCase()]
      public async Task BulkFetch_IMfgProcessInstanceMask()
      {
         MfgProcessInstanceService mfgProcessInstanceService = ServiceFactoryCreate(await Authenticate());

         string[] request = new string[] { };

         try
         {
            (IList<IMfgProcessInstanceMask>, IList<string>) ret = await mfgProcessInstanceService.BulkFetch<IMfgProcessInstanceMask>(request);

            Assert.IsNotNull(ret);
         }
         catch (HttpResponseException _ex)
         {
            string errorMessage = await _ex.GetErrorMessage();
            Assert.Fail(errorMessage);
         }
      }

      [TestCase()]
      public async Task BulkFetch_IMfgProcessInstanceDetailMask()
      {
         MfgProcessInstanceService mfgProcessInstanceService = ServiceFactoryCreate(await Authenticate());

         string[] request = new string[] { }; 

         try
         {
            (IList<IMfgProcessInstanceDetailMask>, IList<string>) ret = await mfgProcessInstanceService.BulkFetch<IMfgProcessInstanceDetailMask>(request);

            Assert.IsNotNull(ret);
         }
         catch (HttpResponseException _ex)
         {
            string errorMessage = await _ex.GetErrorMessage();
            Assert.Fail(errorMessage);
         }
      }
   }
}