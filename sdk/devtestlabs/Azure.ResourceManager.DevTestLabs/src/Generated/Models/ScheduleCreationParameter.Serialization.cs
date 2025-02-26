// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class ScheduleCreationParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(TaskType))
            {
                writer.WritePropertyName("taskType");
                writer.WriteStringValue(TaskType);
            }
            if (Optional.IsDefined(WeeklyRecurrence))
            {
                writer.WritePropertyName("weeklyRecurrence");
                writer.WriteObjectValue(WeeklyRecurrence);
            }
            if (Optional.IsDefined(DailyRecurrence))
            {
                writer.WritePropertyName("dailyRecurrence");
                writer.WriteObjectValue(DailyRecurrence);
            }
            if (Optional.IsDefined(HourlyRecurrence))
            {
                writer.WritePropertyName("hourlyRecurrence");
                writer.WriteObjectValue(HourlyRecurrence);
            }
            if (Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId");
                writer.WriteStringValue(TimeZoneId);
            }
            if (Optional.IsDefined(NotificationSettings))
            {
                writer.WritePropertyName("notificationSettings");
                writer.WriteObjectValue(NotificationSettings);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId");
                writer.WriteStringValue(TargetResourceId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScheduleCreationParameter DeserializeScheduleCreationParameter(JsonElement element)
        {
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<EnableStatus> status = default;
            Optional<string> taskType = default;
            Optional<WeekDetails> weeklyRecurrence = default;
            Optional<DayDetails> dailyRecurrence = default;
            Optional<HourDetails> hourlyRecurrence = default;
            Optional<string> timeZoneId = default;
            Optional<NotificationSettings> notificationSettings = default;
            Optional<string> targetResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new EnableStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("taskType"))
                        {
                            taskType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("weeklyRecurrence"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            weeklyRecurrence = WeekDetails.DeserializeWeekDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dailyRecurrence"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dailyRecurrence = DayDetails.DeserializeDayDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hourlyRecurrence"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hourlyRecurrence = HourDetails.DeserializeHourDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notificationSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            notificationSettings = NotificationSettings.DeserializeNotificationSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"))
                        {
                            targetResourceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScheduleCreationParameter(name.Value, Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToNullable(status), taskType.Value, weeklyRecurrence.Value, dailyRecurrence.Value, hourlyRecurrence.Value, timeZoneId.Value, notificationSettings.Value, targetResourceId.Value);
        }
    }
}
