// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventSubscriptionUpdateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination");
                writer.WriteObjectValue(Destination);
            }
            if (Optional.IsDefined(DeliveryWithResourceIdentity))
            {
                writer.WritePropertyName("deliveryWithResourceIdentity");
                writer.WriteObjectValue(DeliveryWithResourceIdentity);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels");
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExpirationTimeUtc))
            {
                writer.WritePropertyName("expirationTimeUtc");
                writer.WriteStringValue(ExpirationTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(EventDeliverySchema))
            {
                writer.WritePropertyName("eventDeliverySchema");
                writer.WriteStringValue(EventDeliverySchema.Value.ToString());
            }
            if (Optional.IsDefined(RetryPolicy))
            {
                writer.WritePropertyName("retryPolicy");
                writer.WriteObjectValue(RetryPolicy);
            }
            if (Optional.IsDefined(DeadLetterDestination))
            {
                writer.WritePropertyName("deadLetterDestination");
                writer.WriteObjectValue(DeadLetterDestination);
            }
            if (Optional.IsDefined(DeadLetterWithResourceIdentity))
            {
                writer.WritePropertyName("deadLetterWithResourceIdentity");
                writer.WriteObjectValue(DeadLetterWithResourceIdentity);
            }
            writer.WriteEndObject();
        }
    }
}
