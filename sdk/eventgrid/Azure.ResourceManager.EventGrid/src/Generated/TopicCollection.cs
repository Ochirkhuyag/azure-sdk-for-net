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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="TopicResource" /> and their operations.
    /// Each <see cref="TopicResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="TopicCollection" /> instance call the GetTopics method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class TopicCollection : ArmCollection, IEnumerable<TopicResource>, IAsyncEnumerable<TopicResource>
    {
        private readonly ClientDiagnostics _topicClientDiagnostics;
        private readonly TopicsRestOperations _topicRestClient;

        /// <summary> Initializes a new instance of the <see cref="TopicCollection"/> class for mocking. </summary>
        protected TopicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TopicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TopicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topicClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", TopicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TopicResource.ResourceType, out string topicApiVersion);
            _topicRestClient = new TopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Asynchronously creates a new topic with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
        /// Operation Id: Topics_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="data"> Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TopicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string topicName, TopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _topicRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, topicName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<TopicResource>(new TopicOperationSource(Client), _topicClientDiagnostics, Pipeline, _topicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, topicName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Asynchronously creates a new topic with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
        /// Operation Id: Topics_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="data"> Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TopicResource> CreateOrUpdate(WaitUntil waitUntil, string topicName, TopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _topicRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, topicName, data, cancellationToken);
                var operation = new EventGridArmOperation<TopicResource>(new TopicOperationSource(Client), _topicClientDiagnostics, Pipeline, _topicRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, topicName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get properties of a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
        /// Operation Id: Topics_Get
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<TopicResource>> GetAsync(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.Get");
            scope.Start();
            try
            {
                var response = await _topicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
        /// Operation Id: Topics_Get
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<TopicResource> Get(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.Get");
            scope.Start();
            try
            {
                var response = _topicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the topics under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics
        /// Operation Id: Topics_ListByResourceGroup
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the &apos;name&apos; property only and with limited number of OData operations. These operations are: the &apos;contains&apos; function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, &apos;PATTERN&apos;) and name ne &apos;PATTERN-1&apos;. The following is not a valid filter example: $filter=location eq &apos;westus&apos;. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TopicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TopicResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TopicResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _topicRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TopicResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TopicResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _topicRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TopicResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all the topics under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics
        /// Operation Id: Topics_ListByResourceGroup
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the &apos;name&apos; property only and with limited number of OData operations. These operations are: the &apos;contains&apos; function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, &apos;PATTERN&apos;) and name ne &apos;PATTERN-1&apos;. The following is not a valid filter example: $filter=location eq &apos;westus&apos;. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TopicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TopicResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<TopicResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _topicRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TopicResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TopicResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _topicRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TopicResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
        /// Operation Id: Topics_Get
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _topicRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}
        /// Operation Id: Topics_Get
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<bool> Exists(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _topicClientDiagnostics.CreateScope("TopicCollection.Exists");
            scope.Start();
            try
            {
                var response = _topicRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TopicResource> IEnumerable<TopicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TopicResource> IAsyncEnumerable<TopicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
