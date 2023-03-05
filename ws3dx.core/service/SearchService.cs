﻿// ------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2023 Dassault Systèmes - CPE EMED
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
// ------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ws3dx.authentication.data;
using ws3dx.core.exception;
using ws3dx.core.serialization;
using ws3dx.data.collection.impl;
using ws3dx.shared.utils;
using ws3dx.utils.search;

namespace ws3dx.core.service
{
   public abstract class SearchService : EnoviaBaseService
   {
      const long MAX_VALS_PER_QUERY = 1000;
      const long TOP = MAX_VALS_PER_QUERY;

      const string SKIP_PARAM_NAME = "$skip";
      const string TOP_PARAM_NAME = "$top";
      const string SEARCH_CRITERIA_PARAM_NAME = "$searchStr";

      protected virtual string GetSearchSkipParamName() { return SKIP_PARAM_NAME; }
      protected virtual string GetSearchTopParamName() { return TOP_PARAM_NAME; }
      protected virtual string GetSearchCriteriaParamName() { return SEARCH_CRITERIA_PARAM_NAME; }

      protected abstract string GetSearchResource();

      protected abstract IEnumerable<Type> SearchConstraintTypes();

      public SearchService(string _enoviaService, IPassportAuthentication passport) : base(_enoviaService, passport)
      {
      }

      #region Search

      protected bool IsSearchSkipParamNameEmpty { get { return string.IsNullOrEmpty(GetSearchSkipParamName()); } }
      protected bool IsSearchTopParamNameEmpty { get { return string.IsNullOrEmpty(GetSearchTopParamName()); } }

      // Full search
      public async Task<IList<T>> Search<T>(SearchQuery _searchString)
      {
         return await Search<T, NlsLabeledItemSet<T>>(_searchString);
      }

      protected async Task<IList<T>> Search<T, S>(SearchQuery _searchString)
      {
         GenericParameterConstraintUtils.CheckConstraints(typeof(T), SearchConstraintTypes());

         long skip = 0;

         List<T> __output = new List<T>();

         IList<T> page;

         // const int WAIT_MILISECS = 250;
         // bool firstTime = true;

         do
         {
            //TODO: Add an wait interval
            // if (!firstTime)
            // {
            //   await Task.Delay(WAIT_MILISECS);
            // }
            // firstTime = false;

            page = await Search<T, S>(_searchString, skip, TOP);

            skip += TOP;

            if ((page != null) && (page.Count > 0))
            {
               __output.AddRange(page);
            }
         }
         while ((page != null) && (page.Count == TOP));

         return __output;
      }



      //Paged Search
      public async Task<IList<T>> Search<T>(SearchQuery _searchString, long _skip = 0, long _top = 100)
      {
         return await Search<T, NlsLabeledItemSet<T>>(_searchString, _skip, _top);
      }

      protected async Task<IList<T>> Search<T, S>(SearchQuery _searchQuery, long _skip = 0, long _top = 100)
      {
         GenericParameterConstraintUtils.CheckConstraints(typeof(T), SearchConstraintTypes());

         Dictionary<string, string> queryParams = new Dictionary<string, string>();

         if (HasMask)
         {
            queryParams.Add(GetMaskParamName(), MaskNameUtils.GetMaskNameFromType(typeof(T)));
         }

         if (!IsSearchSkipParamNameEmpty) queryParams.Add(GetSearchSkipParamName(), _skip.ToString());
         if (!IsSearchTopParamNameEmpty) queryParams.Add(GetSearchTopParamName(), _top.ToString());

         queryParams.Add(GetSearchCriteriaParamName(), _searchQuery.GetSearchString());

         HttpResponseMessage response = await GetAsync(GetSearchResource(), queryParams);

         if (response.StatusCode != System.Net.HttpStatusCode.OK)
         {
            //handle according to established exception policy
            throw (new SearchResponseException(response));
         }

         string responseContent = await response.Content.ReadAsStringAsync();

         return Deserialize<T, S>(responseContent);
      }

      #endregion

   }
}