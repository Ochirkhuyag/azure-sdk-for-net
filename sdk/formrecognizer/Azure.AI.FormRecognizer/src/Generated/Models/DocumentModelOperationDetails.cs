// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Get Operation response object. </summary>
    public partial class DocumentModelOperationDetails
    {
        /// <summary> Initializes a new instance of DocumentModelOperationDetails. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal DocumentModelOperationDetails(string operationId, DocumentOperationStatus status, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, Uri resourceLocation)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (resourceLocation == null)
            {
                throw new ArgumentNullException(nameof(resourceLocation));
            }

            OperationId = operationId;
            Status = status;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ResourceLocation = resourceLocation;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DocumentModelOperationDetails. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="apiVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="jsonError"> Encountered error. </param>
        internal DocumentModelOperationDetails(string operationId, DocumentOperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, DocumentOperationKind kind, Uri resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags, JsonElement jsonError)
        {
            OperationId = operationId;
            Status = status;
            PercentCompleted = percentCompleted;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Kind = kind;
            ResourceLocation = resourceLocation;
            ApiVersion = apiVersion;
            Tags = tags;
            JsonError = jsonError;
        }

        /// <summary> Operation ID. </summary>
        public string OperationId { get; }
        /// <summary> Operation status. </summary>
        public DocumentOperationStatus Status { get; }
        /// <summary> Operation progress (0-100). </summary>
        public int? PercentCompleted { get; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
