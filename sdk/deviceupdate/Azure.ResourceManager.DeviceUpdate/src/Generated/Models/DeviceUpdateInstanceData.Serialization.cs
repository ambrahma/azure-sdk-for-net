// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    public partial class DeviceUpdateInstanceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IotHubs))
            {
                writer.WritePropertyName("iotHubs");
                writer.WriteStartArray();
                foreach (var item in IotHubs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableDiagnostics))
            {
                writer.WritePropertyName("enableDiagnostics");
                writer.WriteBooleanValue(EnableDiagnostics.Value);
            }
            if (Optional.IsDefined(DiagnosticStorageProperties))
            {
                writer.WritePropertyName("diagnosticStorageProperties");
                writer.WriteObjectValue(DiagnosticStorageProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeviceUpdateInstanceData DeserializeDeviceUpdateInstanceData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            string location = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> accountName = default;
            Optional<IList<IotHubSettings>> iotHubs = default;
            Optional<bool> enableDiagnostics = default;
            Optional<DiagnosticStorageProperties> diagnosticStorageProperties = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accountName"))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iotHubs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IotHubSettings> array = new List<IotHubSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotHubSettings.DeserializeIotHubSettings(item));
                            }
                            iotHubs = array;
                            continue;
                        }
                        if (property0.NameEquals("enableDiagnostics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableDiagnostics = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("diagnosticStorageProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diagnosticStorageProperties = DiagnosticStorageProperties.DeserializeDiagnosticStorageProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeviceUpdateInstanceData(id, name, type, systemData, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), accountName.Value, Optional.ToList(iotHubs), Optional.ToNullable(enableDiagnostics), diagnosticStorageProperties.Value);
        }
    }
}
