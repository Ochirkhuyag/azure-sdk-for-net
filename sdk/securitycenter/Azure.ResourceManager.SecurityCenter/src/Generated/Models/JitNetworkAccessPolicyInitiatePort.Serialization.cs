// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessPolicyInitiatePort : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("number");
            writer.WriteNumberValue(Number);
            if (Optional.IsDefined(AllowedSourceAddressPrefix))
            {
                writer.WritePropertyName("allowedSourceAddressPrefix");
                writer.WriteStringValue(AllowedSourceAddressPrefix);
            }
            writer.WritePropertyName("endTimeUtc");
            writer.WriteStringValue(EndTimeUtc, "O");
            writer.WriteEndObject();
        }
    }
}
