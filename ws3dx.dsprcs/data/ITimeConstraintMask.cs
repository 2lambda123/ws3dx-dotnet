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
using ws3dx.serialization.attribute;

namespace ws3dx.dsprcs.data
{
   [MaskSchema("dsprcs:TimeConstraintMask.Default")]
   public interface ITimeConstraintMask
   {
      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Entity physical id Example: EE562168015FFCF14F940A513C63AA77
      //
      // </summary>
      //----------------------------------------------------------------
      public string Id { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Basic modified value Example: Dec 15, 2017 11:17 PM
      //
      // </summary>
      //----------------------------------------------------------------
      public string Modified { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object created value Example: Dec 11, 2017 12:53 PM
      //
      // </summary>
      //----------------------------------------------------------------
      public string Created { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Indicates FinishToStart(1), StartToStart(2) or FinishToFinish(3) value. Example: 1
      //
      // </summary>
      //----------------------------------------------------------------
      public string DependencyType { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Boolean value whether time constraint is product flow Example: false
      //
      // </summary>
      //----------------------------------------------------------------
      public bool? IsProductFlow { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Delay mode enum value
      //
      // </summary>
      //----------------------------------------------------------------
      public string DelayMode { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Boolean value whether time constraint is optional Example: false
      //
      // </summary>
      //----------------------------------------------------------------
      public bool? IsOptional { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Resource constraint enum value
      //
      // </summary>
      //----------------------------------------------------------------
      public string ResourceConstraint { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Delay real value Example: 0
      //
      // </summary>
      //----------------------------------------------------------------
      public double? Delay { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Product flow category enum value
      //
      // </summary>
      //----------------------------------------------------------------
      public string FlowType { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Return code value Example: RCFail203
      //
      // </summary>
      //----------------------------------------------------------------
      public string ReturnCode { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Maximum retries value Example: 1
      //
      // </summary>
      //----------------------------------------------------------------
      public int? MaximumRetries { get; set; }

      public IList<ISpecifiedOccurrence> FromOperationOccurrence { get; set; }

      public IList<ISpecifiedOccurrence> ToOperationOccurrence { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object cestamp value Example: 2D70169432D84866A200F907881AC9B1
      //
      // </summary>
      //----------------------------------------------------------------
      public string Cestamp { get; set; }
   }
}