// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCosmosDBSqlTriggerResourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(TriggerName);
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body");
                writer.WriteStringValue(Body);
            }
            if (Optional.IsDefined(TriggerType))
            {
                writer.WritePropertyName("triggerType");
                writer.WriteStringValue(TriggerType.Value.ToString());
            }
            if (Optional.IsDefined(TriggerOperation))
            {
                writer.WritePropertyName("triggerOperation");
                writer.WriteStringValue(TriggerOperation.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ExtendedCosmosDBSqlTriggerResourceInfo DeserializeExtendedCosmosDBSqlTriggerResourceInfo(JsonElement element)
        {
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            string id = default;
            Optional<string> body = default;
            Optional<CosmosDBSqlTriggerType> triggerType = default;
            Optional<CosmosDBSqlTriggerOperation> triggerOperation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("body"))
                {
                    body = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    triggerType = new CosmosDBSqlTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggerOperation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    triggerOperation = new CosmosDBSqlTriggerOperation(property.Value.GetString());
                    continue;
                }
            }
            return new ExtendedCosmosDBSqlTriggerResourceInfo(id, body.Value, Optional.ToNullable(triggerType), Optional.ToNullable(triggerOperation), rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }
    }
}
