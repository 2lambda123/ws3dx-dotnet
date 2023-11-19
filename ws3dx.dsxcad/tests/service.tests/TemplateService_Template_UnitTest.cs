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
using System.Collections.Generic;
using System.Threading.Tasks;
using ws3dx.dsxcad.core.service;
using ws3dx.dsxcad.data;
using ws3dx.utils.search;

namespace NUnitTestProject
{
   public class TemplateService_Template_UnitTests : TemplateServiceTestsSetup
   {
      [TestCase("search", 0, 50)]
      public async Task Search_Paged_IXCADTemplateMask(string search, int skip, int top)
      {
         TemplateService templateService = ServiceFactoryCreate(await Authenticate());

         SearchByFreeText searchByFreeText = new SearchByFreeText(search);

         IEnumerable<IXCADTemplateMask> ret = await templateService.Search<IXCADTemplateMask>(searchByFreeText, skip, top);

         Assert.IsNotNull(ret);
      }

      [TestCase("search")]
      public async Task Search_Full_IXCADTemplateMask(string search)
      {
         TemplateService templateService = ServiceFactoryCreate(await Authenticate());

         SearchByFreeText searchByFreeText = new SearchByFreeText(search);

         IEnumerable<IXCADTemplateMask> ret = await templateService.Search<IXCADTemplateMask>(searchByFreeText);

         Assert.IsNotNull(ret);
      }

      [TestCase("")]
      public async Task Get(string templateId)
      {
         TemplateService templateService = ServiceFactoryCreate(await Authenticate());

         IXCADTemplateMask ret = await templateService.Get(templateId);

         Assert.IsNotNull(ret);
      }
   }
}