// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    internal partial class SkillsetsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal SkillsetsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SkillsetsClient for mocking. </summary>
        protected SkillsetsClient()
        {
        }
        /// <summary> Initializes a new instance of SkillsetsClient. </summary>
        internal SkillsetsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string ApiVersion = "2019-05-06-Preview")
        {
            RestClient = new SkillsetsRestClient(clientDiagnostics, pipeline, endpoint, ApiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> CreateOrUpdateAsync(string skillsetName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(skillsetName, xMsClientRequestId, ifMatch, ifNoneMatch, skillset, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> CreateOrUpdate(string skillsetName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(skillsetName, xMsClientRequestId, ifMatch, ifNoneMatch, skillset, cancellationToken);
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string skillsetName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(skillsetName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string skillsetName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(skillsetName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken);
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> GetAsync(string skillsetName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(skillsetName, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> Get(string skillsetName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(skillsetName, xMsClientRequestId, cancellationToken);
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListSkillsetsResult>> ListAsync(string select, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListAsync(select, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListSkillsetsResult> List(string select, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.List(select, xMsClientRequestId, cancellationToken);
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> CreateAsync(Guid? xMsClientRequestId, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(xMsClientRequestId, skillset, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> Create(Guid? xMsClientRequestId, Skillset skillset, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(xMsClientRequestId, skillset, cancellationToken);
        }
    }
}
