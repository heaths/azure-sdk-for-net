// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> HardwareInventoryNetworkInterface represents the network interface details as part of a hardware inventory. </summary>
    public partial class HardwareInventoryNetworkInterface
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HardwareInventoryNetworkInterface"/>. </summary>
        internal HardwareInventoryNetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HardwareInventoryNetworkInterface"/>. </summary>
        /// <param name="linkStatus"> The current status of the link. </param>
        /// <param name="macAddress"> The MAC address associated with this interface. </param>
        /// <param name="name"> The name of the interface. </param>
        /// <param name="networkInterfaceId"> The resource ID of the network interface for the port on the switch that this machine's interface is connected to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HardwareInventoryNetworkInterface(string linkStatus, string macAddress, string name, string networkInterfaceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LinkStatus = linkStatus;
            MacAddress = macAddress;
            Name = name;
            NetworkInterfaceId = networkInterfaceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current status of the link. </summary>
        public string LinkStatus { get; }
        /// <summary> The MAC address associated with this interface. </summary>
        public string MacAddress { get; }
        /// <summary> The name of the interface. </summary>
        public string Name { get; }
        /// <summary> The resource ID of the network interface for the port on the switch that this machine's interface is connected to. </summary>
        public string NetworkInterfaceId { get; }
    }
}
