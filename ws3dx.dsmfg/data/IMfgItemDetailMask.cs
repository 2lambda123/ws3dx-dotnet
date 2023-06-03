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
using ws3dx.dsmfg.data.extension;
using ws3dx.serialization.attribute;
using ws3dx.shared.data;

namespace ws3dx.dsmfg.data
{
   [MaskSchema("dsmfg:MfgItemMask.Details")]
   public interface IMfgItemDetailMask
   {
      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Reference name Example: My name
      //
      // </summary>
      //----------------------------------------------------------------
      public string Name { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Reference object title value Example: My title
      //
      // </summary>
      //----------------------------------------------------------------
      public string Title { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Reference description value Example: My description
      //
      // </summary>
      //----------------------------------------------------------------
      public string Description { get; set; }

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
      // Description: Basic type value Example: My Type
      //
      // </summary>
      //----------------------------------------------------------------
      public string Type { get; set; }

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
      // Description: Object revision value Example: A.1
      //
      // </summary>
      //----------------------------------------------------------------
      public string Revision { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object current state value Example: In Work
      //
      // </summary>
      //----------------------------------------------------------------
      public string State { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object owner value Example: John Doe
      //
      // </summary>
      //----------------------------------------------------------------
      public string Owner { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object organization value Example: MyCompany
      //
      // </summary>
      //----------------------------------------------------------------
      public string Organization { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object collabspace value Example: Default
      //
      // </summary>
      //----------------------------------------------------------------
      public string Collabspace { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Indicates Yes(2) or No(1) value Example: 1
      //
      // </summary>
      //----------------------------------------------------------------
      public string Outsourced { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Indicates Yes(2) or No(1) value Example: 2
      //
      // </summary>
      //----------------------------------------------------------------
      public string PlanningRequired { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: checks whether lot number is required Example: false
      //
      // </summary>
      //----------------------------------------------------------------
      public bool? IsLotNumberRequired { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: checks whether serial number is required Example: false
      //
      // </summary>
      //----------------------------------------------------------------
      public bool? IsSerialNumberRequired { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object estimatedCost value Example: 10
      //
      // </summary>
      //----------------------------------------------------------------
      public double? EstimatedCost { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object estimatedCostCurrency value Example: Default
      //
      // </summary>
      //----------------------------------------------------------------
      public string EstimatedCostCurrency { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object estimatedLeadTimeDescription value Example: Default
      //
      // </summary>
      //----------------------------------------------------------------
      public string EstimatedLeadTimeDescription { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object estimatedWeight value Example: 10
      //
      // </summary>
      //----------------------------------------------------------------
      public double? EstimatedWeight { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object manufacturedItemClassification value Example: Default
      //
      // </summary>
      //----------------------------------------------------------------
      public string ManufacturedItemClassification { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object materialCategory value Example: Default
      //
      // </summary>
      //----------------------------------------------------------------
      public string MaterialCategory { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object spareManufacturedItem value Example: false
      //
      // </summary>
      //----------------------------------------------------------------
      public bool? SpareManufacturedItem { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object targetReleaseDate value Example: Dec 11, 2017 12:53 PM
      //
      // </summary>
      //----------------------------------------------------------------
      public string TargetReleaseDate { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object depthOfFeature value Example: 10
      //
      // </summary>
      //----------------------------------------------------------------
      public double? DepthOfFeature { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object diameterOfFeature value Example: 10
      //
      // </summary>
      //----------------------------------------------------------------
      public double? DiameterOfFeature { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object mfgFastenerStrategy value Example: Default
      //
      // </summary>
      //----------------------------------------------------------------
      public string MfgFastenerStrategy { get; set; }

      //----------------------------------------------------------------
      // <summary>
      //		
      // Description: Object magnitude value, supported values Area,Length, Mass, Volume. Applicable only 
      // for continous Manufacturing Item Types. Example: MASS
      //
      // </summary>
      //----------------------------------------------------------------
      public string Magnitude { get; set; }

      public IEnterpriseItemNumber EnterpriseReference { get; set; }

      public IMfgItemEnterpriseAttributes MfgItemEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes CreateAssemblyEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes CreateKitEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes CreateMaterialEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes ProvideEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes ElementaryEndItemEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes InstallationEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes ProcessContinuousCreateMaterialEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes ProcessContinuousProvideEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes MarkingEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes AnnotationEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes TransformEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes MachineEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes BevelingEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes CuttingEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes GrindingEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes NoDrillEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes DrillEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes PreDrillEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes FastenEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes UnfastenEnterpriseAttributes { get; set; }

      public ICreateKitEnterpriseAttributes SplitProcessEnterpriseAttributes { get; set; }

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