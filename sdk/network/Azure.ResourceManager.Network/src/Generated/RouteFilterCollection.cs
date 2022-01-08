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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of RouteFilter and their operations over its parent. </summary>
    public partial class RouteFilterCollection : ArmCollection, IEnumerable<RouteFilter>, IAsyncEnumerable<RouteFilter>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RouteFiltersRestOperations _routeFiltersRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteFilterCollection"/> class for mocking. </summary>
        protected RouteFilterCollection()
        {
        }

        /// <summary> Initializes a new instance of RouteFilterCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RouteFilterCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _routeFiltersRestClient = new RouteFiltersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public virtual RouteFilterCreateOrUpdateOperation CreateOrUpdate(string routeFilterName, RouteFilterData routeFilterParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routeFiltersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters, cancellationToken);
                var operation = new RouteFilterCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _routeFiltersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public async virtual Task<RouteFilterCreateOrUpdateOperation> CreateOrUpdateAsync(string routeFilterName, RouteFilterData routeFilterParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routeFiltersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters, cancellationToken).ConfigureAwait(false);
                var operation = new RouteFilterCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _routeFiltersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route filter. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<RouteFilter> Get(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.Get");
            scope.Start();
            try
            {
                var response = _routeFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteFilter(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route filter. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public async virtual Task<Response<RouteFilter>> GetAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.Get");
            scope.Start();
            try
            {
                var response = await _routeFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RouteFilter(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<RouteFilter> GetIfExists(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routeFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<RouteFilter>(null, response.GetRawResponse())
                    : Response.FromValue(new RouteFilter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public async virtual Task<Response<RouteFilter>> GetIfExistsAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _routeFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<RouteFilter>(null, response.GetRawResponse())
                    : Response.FromValue(new RouteFilter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeFilterName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (routeFilterName == null)
            {
                throw new ArgumentNullException(nameof(routeFilterName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeFilterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all route filters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RouteFilter" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RouteFilter> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RouteFilter> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeFiltersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RouteFilter> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeFiltersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all route filters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RouteFilter" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RouteFilter> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RouteFilter>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeFiltersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RouteFilter>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeFiltersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="RouteFilter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RouteFilter.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="RouteFilter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteFilterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RouteFilter.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RouteFilter> IEnumerable<RouteFilter>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RouteFilter> IAsyncEnumerable<RouteFilter>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RouteFilter, RouteFilterData> Construct() { }
    }
}
