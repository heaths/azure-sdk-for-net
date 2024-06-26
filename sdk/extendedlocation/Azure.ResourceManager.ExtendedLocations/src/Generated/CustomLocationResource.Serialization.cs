// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ExtendedLocations
{
    public partial class CustomLocationResource : IJsonModel<CustomLocationData>
    {
        void IJsonModel<CustomLocationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CustomLocationData>)Data).Write(writer, options);

        CustomLocationData IJsonModel<CustomLocationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CustomLocationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CustomLocationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CustomLocationData IPersistableModel<CustomLocationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CustomLocationData>(data, options);

        string IPersistableModel<CustomLocationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CustomLocationData>)Data).GetFormatFromOptions(options);
    }
}
