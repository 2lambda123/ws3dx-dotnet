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
using ws3dx.dspfl.data;
using ws3dx.shared.data.extension;

namespace ws3dx.dspfl.core.data.impl
{
   public class NewMatrixRuleData : INewMatrixRuleData
   {
      //------------------------------------------------------------------------------------------------
      //<summary>
      //
      // Example: Color
      //
      //<summary>
      //------------------------------------------------------------------------------------------------
      [JsonPropertyName("title")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string Title { get; set; }

      //------------------------------------------------------------------------------------------------
      //<summary>
      //
      // Example: My object name
      //
      //<summary>
      //------------------------------------------------------------------------------------------------
      [JsonPropertyName("name")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string Name { get; set; }

      //------------------------------------------------------------------------------------------------
      //<summary>
      //
      // Example: My object description
      //
      //<summary>
      //------------------------------------------------------------------------------------------------
      [JsonPropertyName("description")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string Description { get; set; }

      //------------------------------------------------------------------------------------------------
      //<summary>
      //
      // Example: Matrix
      //
      //<summary>
      //------------------------------------------------------------------------------------------------
      [JsonPropertyName("ruleType")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string RuleType { get; set; }

      [JsonPropertyName("ruleDefinition")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public INewMatrixRuleDefinition RuleDefinition { get; set; }

      [JsonPropertyName("ruleCriteria")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public INewMatrixRuleCriteria RuleCriteria { get; set; }

      [JsonPropertyName("customerAttributes")]
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public ICustomerAttributes CustomerAttributes { get; set; }
   }
}