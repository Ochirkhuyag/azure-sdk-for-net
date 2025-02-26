// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing a collection of <see cref="RegisteredServerResource" /> and their operations.
    /// Each <see cref="RegisteredServerResource" /> in the collection will belong to the same instance of <see cref="StorageSyncServiceResource" />.
    /// To get a <see cref="RegisteredServerCollection" /> instance call the GetRegisteredServers method from an instance of <see cref="StorageSyncServiceResource" />.
    /// </summary>
    public partial class RegisteredServerCollection : ArmCollection, IEnumerable<RegisteredServerResource>, IAsyncEnumerable<RegisteredServerResource>
    {
        private readonly ClientDiagnostics _registeredServerClientDiagnostics;
        private readonly RegisteredServersRestOperations _registeredServerRestClient;

        /// <summary> Initializes a new instance of the <see cref="RegisteredServerCollection"/> class for mocking. </summary>
        protected RegisteredServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegisteredServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RegisteredServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _registeredServerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", RegisteredServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RegisteredServerResource.ResourceType, out string registeredServerApiVersion);
            _registeredServerRestClient = new RegisteredServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, registeredServerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageSyncServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageSyncServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add a new registered server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}
        /// Operation Id: RegisteredServers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="content"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<RegisteredServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverId, RegisteredServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverId, nameof(serverId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _registeredServerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<RegisteredServerResource>(new RegisteredServerOperationSource(Client), _registeredServerClientDiagnostics, Pipeline, _registeredServerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a new registered server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}
        /// Operation Id: RegisteredServers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="content"> Body of Registered Server object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<RegisteredServerResource> CreateOrUpdate(WaitUntil waitUntil, string serverId, RegisteredServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverId, nameof(serverId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _registeredServerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content, cancellationToken);
                var operation = new StorageSyncArmOperation<RegisteredServerResource>(new RegisteredServerOperationSource(Client), _registeredServerClientDiagnostics, Pipeline, _registeredServerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given registered server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}
        /// Operation Id: RegisteredServers_Get
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverId"/> is null. </exception>
        public virtual async Task<Response<RegisteredServerResource>> GetAsync(string serverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverId, nameof(serverId));

            using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _registeredServerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegisteredServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given registered server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}
        /// Operation Id: RegisteredServers_Get
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverId"/> is null. </exception>
        public virtual Response<RegisteredServerResource> Get(string serverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverId, nameof(serverId));

            using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.Get");
            scope.Start();
            try
            {
                var response = _registeredServerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegisteredServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given registered server list.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers
        /// Operation Id: RegisteredServers_ListByStorageSyncService
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RegisteredServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RegisteredServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RegisteredServerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _registeredServerRestClient.ListByStorageSyncServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RegisteredServerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get a given registered server list.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers
        /// Operation Id: RegisteredServers_ListByStorageSyncService
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RegisteredServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RegisteredServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RegisteredServerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _registeredServerRestClient.ListByStorageSyncService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RegisteredServerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}
        /// Operation Id: RegisteredServers_Get
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverId, nameof(serverId));

            using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _registeredServerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/registeredServers/{serverId}
        /// Operation Id: RegisteredServers_Get
        /// </summary>
        /// <param name="serverId"> GUID identifying the on-premises server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverId"/> is null. </exception>
        public virtual Response<bool> Exists(string serverId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverId, nameof(serverId));

            using var scope = _registeredServerClientDiagnostics.CreateScope("RegisteredServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _registeredServerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RegisteredServerResource> IEnumerable<RegisteredServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RegisteredServerResource> IAsyncEnumerable<RegisteredServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
