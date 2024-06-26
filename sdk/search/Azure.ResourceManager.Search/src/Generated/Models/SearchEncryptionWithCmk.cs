// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes a policy that determines how resources within the search service are to be encrypted with customer managed keys. </summary>
    public partial class SearchEncryptionWithCmk
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

        /// <summary> Initializes a new instance of <see cref="SearchEncryptionWithCmk"/>. </summary>
        public SearchEncryptionWithCmk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchEncryptionWithCmk"/>. </summary>
        /// <param name="enforcement"> Describes how a search service should enforce compliance if it finds objects that aren't encrypted with the customer-managed key. </param>
        /// <param name="encryptionComplianceStatus"> Returns the status of search service compliance with respect to non-CMK-encrypted objects. If a service has more than one unencrypted object, and enforcement is enabled, the service is marked as noncompliant. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchEncryptionWithCmk(SearchEncryptionWithCmkEnforcement? enforcement, SearchEncryptionComplianceStatus? encryptionComplianceStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enforcement = enforcement;
            EncryptionComplianceStatus = encryptionComplianceStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Describes how a search service should enforce compliance if it finds objects that aren't encrypted with the customer-managed key. </summary>
        [WirePath("enforcement")]
        public SearchEncryptionWithCmkEnforcement? Enforcement { get; set; }
        /// <summary> Returns the status of search service compliance with respect to non-CMK-encrypted objects. If a service has more than one unencrypted object, and enforcement is enabled, the service is marked as noncompliant. </summary>
        [WirePath("encryptionComplianceStatus")]
        public SearchEncryptionComplianceStatus? EncryptionComplianceStatus { get; }
    }
}
