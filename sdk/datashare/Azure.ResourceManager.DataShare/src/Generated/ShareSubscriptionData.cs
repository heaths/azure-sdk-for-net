// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the ShareSubscription data model.
    /// A share subscription data transfer object.
    /// </summary>
    public partial class ShareSubscriptionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ShareSubscriptionData"/>. </summary>
        /// <param name="invitationId"> The invitation id. </param>
        /// <param name="sourceShareLocation"> Source share location. </param>
        public ShareSubscriptionData(Guid invitationId, AzureLocation sourceShareLocation)
        {
            InvitationId = invitationId;
            SourceShareLocation = sourceShareLocation;
        }

        /// <summary> Initializes a new instance of <see cref="ShareSubscriptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Time at which the share subscription was created. </param>
        /// <param name="expireOn"> The expiration date of the share subscription. </param>
        /// <param name="invitationId"> The invitation id. </param>
        /// <param name="providerEmail"> Email of the provider who created the resource. </param>
        /// <param name="providerName"> Name of the provider who created the resource. </param>
        /// <param name="providerTenantName"> Tenant name of the provider who created the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the share subscription. </param>
        /// <param name="shareDescription"> Description of share. </param>
        /// <param name="shareKind"> Kind of share. </param>
        /// <param name="shareName"> Name of the share. </param>
        /// <param name="shareSubscriptionStatus"> Gets the current status of share subscription. </param>
        /// <param name="shareTerms"> Terms of a share. </param>
        /// <param name="sourceShareLocation"> Source share location. </param>
        /// <param name="userEmail"> Email of the user who created the resource. </param>
        /// <param name="userName"> Name of the user who created the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareSubscriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, DateTimeOffset? expireOn, Guid invitationId, string providerEmail, string providerName, string providerTenantName, DataShareProvisioningState? provisioningState, string shareDescription, DataShareKind? shareKind, string shareName, ShareSubscriptionStatus? shareSubscriptionStatus, string shareTerms, AzureLocation sourceShareLocation, string userEmail, string userName, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            ExpireOn = expireOn;
            InvitationId = invitationId;
            ProviderEmail = providerEmail;
            ProviderName = providerName;
            ProviderTenantName = providerTenantName;
            ProvisioningState = provisioningState;
            ShareDescription = shareDescription;
            ShareKind = shareKind;
            ShareName = shareName;
            ShareSubscriptionStatus = shareSubscriptionStatus;
            ShareTerms = shareTerms;
            SourceShareLocation = sourceShareLocation;
            UserEmail = userEmail;
            UserName = userName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ShareSubscriptionData"/> for deserialization. </summary>
        internal ShareSubscriptionData()
        {
        }

        /// <summary> Time at which the share subscription was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The expiration date of the share subscription. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The invitation id. </summary>
        public Guid InvitationId { get; set; }
        /// <summary> Email of the provider who created the resource. </summary>
        public string ProviderEmail { get; }
        /// <summary> Name of the provider who created the resource. </summary>
        public string ProviderName { get; }
        /// <summary> Tenant name of the provider who created the resource. </summary>
        public string ProviderTenantName { get; }
        /// <summary> Provisioning state of the share subscription. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Description of share. </summary>
        public string ShareDescription { get; }
        /// <summary> Kind of share. </summary>
        public DataShareKind? ShareKind { get; }
        /// <summary> Name of the share. </summary>
        public string ShareName { get; }
        /// <summary> Gets the current status of share subscription. </summary>
        public ShareSubscriptionStatus? ShareSubscriptionStatus { get; }
        /// <summary> Terms of a share. </summary>
        public string ShareTerms { get; }
        /// <summary> Source share location. </summary>
        public AzureLocation SourceShareLocation { get; set; }
        /// <summary> Email of the user who created the resource. </summary>
        public string UserEmail { get; }
        /// <summary> Name of the user who created the resource. </summary>
        public string UserName { get; }
    }
}
