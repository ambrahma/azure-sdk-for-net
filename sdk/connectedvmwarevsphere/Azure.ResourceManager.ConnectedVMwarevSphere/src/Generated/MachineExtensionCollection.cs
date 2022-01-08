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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of MachineExtension and their operations over its parent. </summary>
    public partial class MachineExtensionCollection : ArmCollection, IEnumerable<MachineExtension>, IAsyncEnumerable<MachineExtension>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly MachineExtensionsRestOperations _machineExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineExtensionCollection"/> class for mocking. </summary>
        protected MachineExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of MachineExtensionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal MachineExtensionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _machineExtensionsRestClient = new MachineExtensionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualMachine.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_CreateOrUpdate
        /// <summary> The operation to create or update the extension. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public virtual MachineExtensionCreateOrUpdateOperation CreateOrUpdate(string extensionName, MachineExtensionData extensionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineExtensionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters, cancellationToken);
                var operation = new MachineExtensionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _machineExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_CreateOrUpdate
        /// <summary> The operation to create or update the extension. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="extensionParameters"/> is null. </exception>
        public async virtual Task<MachineExtensionCreateOrUpdateOperation> CreateOrUpdateAsync(string extensionName, MachineExtensionData extensionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineExtensionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new MachineExtensionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _machineExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, extensionParameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> The operation to get the extension. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<MachineExtension> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _machineExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineExtension(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions/{extensionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_Get
        /// <summary> The operation to get the extension. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public async virtual Task<Response<MachineExtension>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MachineExtension(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<MachineExtension> GetIfExists(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<MachineExtension>(null, response.GetRawResponse())
                    : Response.FromValue(new MachineExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public async virtual Task<Response<MachineExtension>> GetIfExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _machineExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<MachineExtension>(null, response.GetRawResponse())
                    : Response.FromValue(new MachineExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(extensionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_List
        /// <summary> The operation to get all extensions of a non-Azure machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineExtension> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<MachineExtension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machineExtensionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MachineExtension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machineExtensionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{name}/extensions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: MachineExtensions_List
        /// <summary> The operation to get all extensions of a non-Azure machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineExtension> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<MachineExtension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machineExtensionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MachineExtension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machineExtensionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<MachineExtension> IEnumerable<MachineExtension>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineExtension> IAsyncEnumerable<MachineExtension>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, MachineExtension, MachineExtensionData> Construct() { }
    }
}
