// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AnalysisDefinition and their operations over its parent. </summary>
    public partial class SiteDiagnosticAnalysisCollection : ArmCollection, IEnumerable<SiteDiagnosticAnalysis>, IAsyncEnumerable<SiteDiagnosticAnalysis>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticsRestOperations _diagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticAnalysisCollection"/> class for mocking. </summary>
        protected SiteDiagnosticAnalysisCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteDiagnosticAnalysisCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteDiagnosticAnalysisCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _diagnosticsRestClient = new DiagnosticsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteDiagnostic.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteAnalysis
        /// <summary> Description for Get Site Analysis. </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<SiteDiagnosticAnalysis> Get(string analysisName, CancellationToken cancellationToken = default)
        {
            if (analysisName == null)
            {
                throw new ArgumentNullException(nameof(analysisName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteAnalysis(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticAnalysis(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteAnalysis
        /// <summary> Description for Get Site Analysis. </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public async virtual Task<Response<SiteDiagnosticAnalysis>> GetAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            if (analysisName == null)
            {
                throw new ArgumentNullException(nameof(analysisName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteAnalysisAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteDiagnosticAnalysis(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<SiteDiagnosticAnalysis> GetIfExists(string analysisName, CancellationToken cancellationToken = default)
        {
            if (analysisName == null)
            {
                throw new ArgumentNullException(nameof(analysisName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteAnalysis(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteDiagnosticAnalysis>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteDiagnosticAnalysis(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public async virtual Task<Response<SiteDiagnosticAnalysis>> GetIfExistsAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            if (analysisName == null)
            {
                throw new ArgumentNullException(nameof(analysisName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteAnalysisAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteDiagnosticAnalysis>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteDiagnosticAnalysis(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<bool> Exists(string analysisName, CancellationToken cancellationToken = default)
        {
            if (analysisName == null)
            {
                throw new ArgumentNullException(nameof(analysisName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(analysisName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            if (analysisName == null)
            {
                throw new ArgumentNullException(nameof(analysisName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(analysisName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_ListSiteAnalyses
        /// <summary> Description for Get Site Analyses. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDiagnosticAnalysis" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDiagnosticAnalysis> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteDiagnosticAnalysis> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteAnalyses(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnosticAnalysis(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteDiagnosticAnalysis> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteAnalysesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnosticAnalysis(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_ListSiteAnalyses
        /// <summary> Description for Get Site Analyses. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDiagnosticAnalysis" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDiagnosticAnalysis> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteDiagnosticAnalysis>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteAnalysesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnosticAnalysis(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteDiagnosticAnalysis>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteAnalysesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnosticAnalysis(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteDiagnosticAnalysis> IEnumerable<SiteDiagnosticAnalysis>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDiagnosticAnalysis> IAsyncEnumerable<SiteDiagnosticAnalysis>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteDiagnosticAnalysis, AnalysisDefinitionData> Construct() { }
    }
}
