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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="AlertResource" /> and their operations.
    /// Each <see cref="AlertResource" /> in the collection will belong to the same instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// To get an <see cref="AlertCollection" /> instance call the GetAlerts method from an instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// </summary>
    public partial class AlertCollection : ArmCollection, IEnumerable<AlertResource>, IAsyncEnumerable<AlertResource>
    {
        private readonly ClientDiagnostics _alertClientDiagnostics;
        private readonly AlertsRestOperations _alertRestClient;

        /// <summary> Initializes a new instance of the <see cref="AlertCollection"/> class for mocking. </summary>
        protected AlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AlertCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _alertClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", AlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AlertResource.ResourceType, out string alertApiVersion);
            _alertRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, alertApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeDeviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an alert by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts/{name}
        /// Operation Id: Alerts_Get
        /// </summary>
        /// <param name="name"> The alert name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AlertResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _alertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an alert by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts/{name}
        /// Operation Id: Alerts_Get
        /// </summary>
        /// <param name="name"> The alert name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AlertResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.Get");
            scope.Start();
            try
            {
                var response = _alertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the alerts for a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts
        /// Operation Id: Alerts_ListByDataBoxEdgeDevice
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AlertResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AlertResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _alertRestClient.ListByDataBoxEdgeDeviceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AlertResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _alertRestClient.ListByDataBoxEdgeDeviceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the alerts for a Data Box Edge/Data Box Gateway device.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts
        /// Operation Id: Alerts_ListByDataBoxEdgeDevice
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AlertResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AlertResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _alertRestClient.ListByDataBoxEdgeDevice(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AlertResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _alertRestClient.ListByDataBoxEdgeDeviceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts/{name}
        /// Operation Id: Alerts_Get
        /// </summary>
        /// <param name="name"> The alert name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _alertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/alerts/{name}
        /// Operation Id: Alerts_Get
        /// </summary>
        /// <param name="name"> The alert name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _alertClientDiagnostics.CreateScope("AlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _alertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AlertResource> IEnumerable<AlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AlertResource> IAsyncEnumerable<AlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
