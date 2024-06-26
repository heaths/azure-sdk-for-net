// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TrustedSigning.Mocking;
using Azure.ResourceManager.TrustedSigning.Models;

namespace Azure.ResourceManager.TrustedSigning
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.TrustedSigning. </summary>
    public static partial class TrustedSigningExtensions
    {
        private static MockableTrustedSigningArmClient GetMockableTrustedSigningArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableTrustedSigningArmClient(client0));
        }

        private static MockableTrustedSigningResourceGroupResource GetMockableTrustedSigningResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableTrustedSigningResourceGroupResource(client, resource.Id));
        }

        private static MockableTrustedSigningSubscriptionResource GetMockableTrustedSigningSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableTrustedSigningSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrustedSigningAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrustedSigningAccountResource.CreateResourceIdentifier" /> to create a <see cref="TrustedSigningAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningArmClient.GetTrustedSigningAccountResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrustedSigningAccountResource"/> object. </returns>
        public static TrustedSigningAccountResource GetTrustedSigningAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableTrustedSigningArmClient(client).GetTrustedSigningAccountResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrustedSigningCertificateProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrustedSigningCertificateProfileResource.CreateResourceIdentifier" /> to create a <see cref="TrustedSigningCertificateProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningArmClient.GetTrustedSigningCertificateProfileResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrustedSigningCertificateProfileResource"/> object. </returns>
        public static TrustedSigningCertificateProfileResource GetTrustedSigningCertificateProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableTrustedSigningArmClient(client).GetTrustedSigningCertificateProfileResource(id);
        }

        /// <summary>
        /// Gets a collection of TrustedSigningAccountResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningResourceGroupResource.GetTrustedSigningAccounts()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of TrustedSigningAccountResources and their operations over a TrustedSigningAccountResource. </returns>
        public static TrustedSigningAccountCollection GetTrustedSigningAccounts(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableTrustedSigningResourceGroupResource(resourceGroupResource).GetTrustedSigningAccounts();
        }

        /// <summary>
        /// Get a trusted Signing Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CodeSigning/codeSigningAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CodeSigningAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrustedSigningAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningResourceGroupResource.GetTrustedSigningAccountAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> Trusted Signing account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<TrustedSigningAccountResource>> GetTrustedSigningAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableTrustedSigningResourceGroupResource(resourceGroupResource).GetTrustedSigningAccountAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a trusted Signing Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CodeSigning/codeSigningAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CodeSigningAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrustedSigningAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningResourceGroupResource.GetTrustedSigningAccount(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> Trusted Signing account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<TrustedSigningAccountResource> GetTrustedSigningAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableTrustedSigningResourceGroupResource(resourceGroupResource).GetTrustedSigningAccount(accountName, cancellationToken);
        }

        /// <summary>
        /// Checks that the trusted signing account name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CodeSigning/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CodeSigningAccounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrustedSigningAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningSubscriptionResource.CheckTrustedSigningAccountNameAvailability(TrustedSigningAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The CheckAvailability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<TrustedSigningAccountNameAvailabilityResult>> CheckTrustedSigningAccountNameAvailabilityAsync(this SubscriptionResource subscriptionResource, TrustedSigningAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableTrustedSigningSubscriptionResource(subscriptionResource).CheckTrustedSigningAccountNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the trusted signing account name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CodeSigning/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CodeSigningAccounts_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrustedSigningAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningSubscriptionResource.CheckTrustedSigningAccountNameAvailability(TrustedSigningAccountNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The CheckAvailability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<TrustedSigningAccountNameAvailabilityResult> CheckTrustedSigningAccountNameAvailability(this SubscriptionResource subscriptionResource, TrustedSigningAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTrustedSigningSubscriptionResource(subscriptionResource).CheckTrustedSigningAccountNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists trusted signing accounts within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CodeSigning/codeSigningAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CodeSigningAccounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrustedSigningAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningSubscriptionResource.GetTrustedSigningAccounts(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="TrustedSigningAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TrustedSigningAccountResource> GetTrustedSigningAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTrustedSigningSubscriptionResource(subscriptionResource).GetTrustedSigningAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists trusted signing accounts within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CodeSigning/codeSigningAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CodeSigningAccounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-05-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrustedSigningAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrustedSigningSubscriptionResource.GetTrustedSigningAccounts(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="TrustedSigningAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TrustedSigningAccountResource> GetTrustedSigningAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTrustedSigningSubscriptionResource(subscriptionResource).GetTrustedSigningAccounts(cancellationToken);
        }
    }
}
