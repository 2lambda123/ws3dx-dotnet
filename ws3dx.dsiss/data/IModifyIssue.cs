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
using ws3dx.data;

namespace ws3dx.dsiss.data
{
   public interface IModifyIssue
   {
      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: F718B05686760000926EEB5BE7400900
      //
      // </summary>
      //----------------------------------------------------------------
      public string Cestamp { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Description of Issue
      //
      // </summary>
      //----------------------------------------------------------------
      public string Description { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Title of Issue
      //
      // </summary>
      //----------------------------------------------------------------
      public string Title { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Low
      //
      // </summary>
      //----------------------------------------------------------------
      public string Priority { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Fri Jul 21 02:00:00 CEST 2017
      //
      // </summary>
      //----------------------------------------------------------------
      public string EstimatedStartDate { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Fri Jul 21 02:00:00 CEST 2017
      //
      // </summary>
      //----------------------------------------------------------------
      public string ActualStartDate { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Sat Jul 22 02:00:00 CEST 2017
      //
      // </summary>
      //----------------------------------------------------------------
      public string EstimatedEndDate { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Sat Jul 22 02:00:00 CEST 2017
      //
      // </summary>
      //----------------------------------------------------------------
      public string ActualEndDate { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: No
      //
      // </summary>
      //----------------------------------------------------------------
      public string EscalationRequired { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Example: Recommendation details for resolution
      //
      // </summary>
      //----------------------------------------------------------------
      public string ResolutionRecommendation { get; set; }

      public IExtendedAttributes IssueEnterpriseAttributes { get; set; }

      public IList<IModifyIssueRemove> Remove { get; set; }

      public IList<IModifyIssueAdd> Add { get; set; }

      public IList<IModifyIssueReplace> Replace { get; set; }
   }
}