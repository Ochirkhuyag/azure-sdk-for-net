// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class NlpVerticalDataSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData");
                    writer.WriteObjectValue(ValidationData);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            writer.WritePropertyName("targetColumnName");
            writer.WriteStringValue(TargetColumnName);
            if (Optional.IsDefined(TestData))
            {
                if (TestData != null)
                {
                    writer.WritePropertyName("testData");
                    writer.WriteObjectValue(TestData);
                }
                else
                {
                    writer.WriteNull("testData");
                }
            }
            writer.WritePropertyName("trainingData");
            writer.WriteObjectValue(TrainingDataSettings);
            writer.WriteEndObject();
        }

        internal static NlpVerticalDataSettings DeserializeNlpVerticalDataSettings(JsonElement element)
        {
            Optional<NlpVerticalValidationDataSettings> validationData = default;
            string targetColumnName = default;
            Optional<TestDataSettings> testData = default;
            TrainingDataSettings trainingData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = NlpVerticalValidationDataSettings.DeserializeNlpVerticalValidationDataSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("targetColumnName"))
                {
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testData = null;
                        continue;
                    }
                    testData = TestDataSettings.DeserializeTestDataSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("trainingData"))
                {
                    trainingData = TrainingDataSettings.DeserializeTrainingDataSettings(property.Value);
                    continue;
                }
            }
            return new NlpVerticalDataSettings(targetColumnName, testData.Value, trainingData, validationData.Value);
        }
    }
}
