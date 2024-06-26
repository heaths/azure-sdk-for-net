// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    public partial class SnapshotResource : IJsonModel<SnapshotResourceData>
    {
        void IJsonModel<SnapshotResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SnapshotResourceData>)Data).Write(writer, options);

        SnapshotResourceData IJsonModel<SnapshotResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SnapshotResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SnapshotResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SnapshotResourceData IPersistableModel<SnapshotResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SnapshotResourceData>(data, options);

        string IPersistableModel<SnapshotResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SnapshotResourceData>)Data).GetFormatFromOptions(options);
    }
}
