// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class Circuit : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static Circuit DeserializeCircuit(JsonElement element)
        {
            Optional<string> primarySubnet = default;
            Optional<string> secondarySubnet = default;
            Optional<string> expressRouteId = default;
            Optional<string> expressRoutePrivatePeeringId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarySubnet"))
                {
                    primarySubnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondarySubnet"))
                {
                    secondarySubnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expressRouteID"))
                {
                    expressRouteId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expressRoutePrivatePeeringID"))
                {
                    expressRoutePrivatePeeringId = property.Value.GetString();
                    continue;
                }
            }
            return new Circuit(primarySubnet.Value, secondarySubnet.Value, expressRouteId.Value, expressRoutePrivatePeeringId.Value);
        }
    }
}
