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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ws3dx.authentication.data;
using ws3dx.core.service;
using ws3dx.project.project.data;
using ws3dx.utils.search;

namespace ws3dx.project.project.core.service
{
   // SDK Service
   public class ProjectService : SearchService
   {
      private const string BASE_RESOURCE = "/resources/v1/modeler";

      public ProjectService(string enoviaService, IPassportAuthentication passport) : base(enoviaService, passport)
      {
      }

      protected string GetBaseResource()
      {
         return BASE_RESOURCE;
      }

      #region SearchService overrides
      protected override string GetSearchResource()
      {
         return $"{GetBaseResource()}/projects/search";
      }

      protected override IEnumerable<Type> SearchConstraintTypes()
      {
         return new List<Type>() { typeof(IResponseProjectData) };
      }

      protected override string GetSearchSkipParamName()
      {
         return "$skip";
      }

      protected override string GetSearchTopParamName()
      {
         return "$top";
      }

      protected override string GetSearchCriteriaParamName()
      {
         return "searchStr";
      }

      public async Task<IList<IResponseProjectData>> Search(SearchQuery searchQuery)
      {
         return await SearchCollection<IResponseProjectData>("data", searchQuery);
      }

      public async Task<IList<IResponseProjectData>> Search(SearchQuery searchQuery, long _skip, long _top)
      {
         return await SearchCollection<IResponseProjectData>("data", searchQuery, _skip, _top);
      }

      protected override string GetMaskParamName() { return null; }

      #endregion

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}/risks/{riskId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the risk details for a given project & risk id.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IResponseRiskData> GetProjectRisk(string projectId, string riskId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/risks/{riskId}";

         return await GetIndividualFromResponseDataProperty<IResponseRiskData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}/issues
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get Project Issues for a given project.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IList<IResponseIssueData>> GetProjectIssues(string projectId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/issues";

         return await GetCollectionFromResponseDataProperty<IResponseIssueData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}/assessments/{assessmentId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the information for a given Assessment.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IResponseAssessmentData> GetProjectAssessment(string projectId, string assessmentId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/assessments/{assessmentId}";

         return await GetIndividualFromResponseDataProperty<IResponseAssessmentData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get all users Projects.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IList<IResponseProjectData>> GetAllProjects()
      {
         string resourceURI = $"{GetBaseResource()}/projects";

         return await GetCollectionFromResponseDataProperty<IResponseProjectData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}/assessments
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the latest Assessment for a given Project.
      // <param name="allAssessments">
      // Description: Optionally retrieve all Assessments for the Project. (Default: false)
      // </param>
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IList<IResponseAssessmentData>> GetProjectAssessments(string projectId, string allAssessments)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/assessments";

         IDictionary<string, string> queryParams = new Dictionary<string, string>();
         queryParams.Add("allAssessments", allAssessments);

         return await GetCollectionFromResponseDataProperty<IResponseAssessmentData>(resourceURI, queryParams: queryParams);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}/issues/{issueId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the issue details for a given project & issue id.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IResponseIssueData> GetProjectIssue(string projectId, string issueId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/issues/{issueId}";

         return await GetIndividualFromResponseDataProperty<IResponseIssueData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/programId/{programId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the projects for a given program id
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IList<IResponseProjectData>> GetProgramProjects(string programId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/programId/{programId}";

         return await GetCollectionFromResponseDataProperty<IResponseProjectData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}/risks
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the risks associated directly to a given project.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IList<IResponseRiskData>> GetProjectRisks(string projectId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/risks";

         return await GetCollectionFromResponseDataProperty<IResponseRiskData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/folderId/{folderId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the information for a given folder object associated with any project.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IResponseFolderData> GetProjectFolder(string folderId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/folderId/{folderId}";

         return await GetIndividualFromResponseDataProperty<IResponseFolderData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get a specific Project detail and related data.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IResponseProjectData> GetProject(string projectId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}";

         return await GetIndividualFromResponseDataProperty<IResponseProjectData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (GET) /projects/{projectId}/folders
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Get the folders for a given project id.
      // </summary>
      //---------------------------------------------------------------------------------------------		
      public async Task<IList<IResponseFolderData>> GetProjectFolders(string projectId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/folders";

         return await GetCollectionFromResponseDataProperty<IResponseFolderData>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (POST) /projects/{projectId}/assessments
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Create an Assessment for a given Project.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IResponseAssessmentData> AddProjectAssessment(string projectId, IAssessments assessments)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/assessments";

         return await PostIndividual<IResponseAssessmentData, IAssessments>(resourceURI, assessments);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (POST) /projects
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Create projects and related data.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IResponseProjectData> CreateProject(IProjects projects)
      {
         string resourceURI = $"{GetBaseResource()}/projects";

         return await PostIndividualFromResponseDataProperty<IResponseProjectData, IProjects>(resourceURI, projects);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (POST) /projects/{projectId}/folders
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Create the folders for a given project id.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IResponseFolderData> AddProjectFolder(string projectId, IFolders folders)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/folders";

         return await PostIndividualFromResponseDataProperty<IResponseFolderData, IFolders>(resourceURI, folders);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (PUT) /projects/{projectId}/assessments
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Update the Assessments for a given Project.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IList<IResponseAssessmentData>> UpdateProjectAssessments(string projectId, IAssessments assessments)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/assessments";

         return await PutCollectionFromResponseDataProperty<IResponseAssessmentData, IAssessments>(resourceURI, assessments);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (PUT) /projects/{projectId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Update projects and related data.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IList<IResponseProjectData>> UpdateProject(string projectId, IProjects projects)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}";

         return await PutCollectionFromResponseDataProperty<IResponseProjectData, IProjects>(resourceURI, projects);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (PUT) /projects/{projectId}/folders
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Update the folders for a given project id.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IList<IResponseFolderData>> UpdateProjectFolders(string projectId, IFolders folders)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/folders";

         return await PutCollectionFromResponseDataProperty<IResponseFolderData, IFolders>(resourceURI, folders);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (PUT) /projects/{projectId}/assessments/{assessmentId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Update an Assessment for a given Project.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IList<IResponseAssessmentData>> UpdateProjectAssessment(string projectId, string assessmentId, IAssessments assessments)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/assessments/{assessmentId}";

         return await PutCollectionFromResponseDataProperty<IResponseAssessmentData, IAssessments>(resourceURI, assessments);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (PUT) /projects
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Update projects and related data.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IList<IResponseProjectData>> UpdateProjects(IProjects projects)
      {
         string resourceURI = $"{GetBaseResource()}/projects";

         return await PutCollectionFromResponseDataProperty<IResponseProjectData, IProjects>(resourceURI, projects);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (DELETE) /projects/{projectId}/assessments/{assessmentId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Delete an Assessment for a given Project.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IResponseEmpty> DeleteProjectAssessment(string projectId, string assessmentId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/assessments/{assessmentId}";

         return await DeleteIndividual<IResponseEmpty>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (DELETE) /projects/{projectId}/folders/{folderId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Delete a given folder based on the given project & folder id.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IResponseEmpty> DeleteProjectFolder(string projectId, string folderId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}/folders/{folderId}";

         return await DeleteIndividual<IResponseEmpty>(resourceURI);
      }

      //---------------------------------------------------------------------------------------------
      // <remarks>
      // (DELETE) /projects/{projectId}
      // </remarks>
      //---------------------------------------------------------------------------------------------
      // <summary>
      // Description: Summary: Delete the given project.
      // </summary>
      //---------------------------------------------------------------------------------------------
      public async Task<IResponseEmpty> DeleteProject(string projectId)
      {
         string resourceURI = $"{GetBaseResource()}/projects/{projectId}";

         return await DeleteIndividual<IResponseEmpty>(resourceURI);
      }
   }
}