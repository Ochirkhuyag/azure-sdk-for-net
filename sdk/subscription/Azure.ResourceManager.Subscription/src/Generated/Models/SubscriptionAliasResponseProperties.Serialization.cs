// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class SubscriptionAliasResponseProperties
    {
        internal static SubscriptionAliasResponseProperties DeserializeSubscriptionAliasResponseProperties(JsonElement element)
        {
            Optional<string> subscriptionId = default;
            Optional<string> displayName = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<Uri> acceptOwnershipUrl = default;
            Optional<AcceptOwnership> acceptOwnershipState = default;
            Optional<string> billingScope = default;
            Optional<Workload> workload = default;
            Optional<string> resellerId = default;
            Optional<string> subscriptionOwnerId = default;
            Optional<string> managementGroupId = default;
            Optional<string> createdTime = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acceptOwnershipUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acceptOwnershipUrl = null;
                        continue;
                    }
                    acceptOwnershipUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acceptOwnershipState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    acceptOwnershipState = new AcceptOwnership(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingScope"))
                {
                    billingScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workload"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workload = new Workload(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resellerId"))
                {
                    resellerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionOwnerId"))
                {
                    subscriptionOwnerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementGroupId"))
                {
                    managementGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new SubscriptionAliasResponseProperties(subscriptionId.Value, displayName.Value, Optional.ToNullable(provisioningState), acceptOwnershipUrl.Value, Optional.ToNullable(acceptOwnershipState), billingScope.Value, Optional.ToNullable(workload), resellerId.Value, subscriptionOwnerId.Value, managementGroupId.Value, createdTime.Value, Optional.ToDictionary(tags));
        }
    }
}
