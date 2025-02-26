// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class SynchronizationDetails
    {
        internal static SynchronizationDetails DeserializeSynchronizationDetails(JsonElement element)
        {
            Optional<string> dataSetId = default;
            Optional<DataSetType> dataSetType = default;
            Optional<int> durationMs = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<long> filesRead = default;
            Optional<long> filesWritten = default;
            Optional<string> message = default;
            Optional<string> name = default;
            Optional<long> rowsCopied = default;
            Optional<long> rowsRead = default;
            Optional<long> sizeRead = default;
            Optional<long> sizeWritten = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> status = default;
            Optional<long> vCore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSetId"))
                {
                    dataSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSetType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataSetType = new DataSetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("durationMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    durationMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("filesRead"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filesRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesWritten"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filesWritten = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowsCopied"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rowsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rowsRead"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rowsRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sizeRead"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sizeRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sizeWritten"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sizeWritten = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCore"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vCore = property.Value.GetInt64();
                    continue;
                }
            }
            return new SynchronizationDetails(dataSetId.Value, Optional.ToNullable(dataSetType), Optional.ToNullable(durationMs), Optional.ToNullable(endTime), Optional.ToNullable(filesRead), Optional.ToNullable(filesWritten), message.Value, name.Value, Optional.ToNullable(rowsCopied), Optional.ToNullable(rowsRead), Optional.ToNullable(sizeRead), Optional.ToNullable(sizeWritten), Optional.ToNullable(startTime), status.Value, Optional.ToNullable(vCore));
        }
    }
}
