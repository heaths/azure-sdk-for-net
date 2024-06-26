// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.StandbyPool
{
    internal class StandbyVirtualMachinePoolOperationSource : IOperationSource<StandbyVirtualMachinePoolResource>
    {
        private readonly ArmClient _client;

        internal StandbyVirtualMachinePoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        StandbyVirtualMachinePoolResource IOperationSource<StandbyVirtualMachinePoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StandbyVirtualMachinePoolData.DeserializeStandbyVirtualMachinePoolData(document.RootElement);
            return new StandbyVirtualMachinePoolResource(_client, data);
        }

        async ValueTask<StandbyVirtualMachinePoolResource> IOperationSource<StandbyVirtualMachinePoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StandbyVirtualMachinePoolData.DeserializeStandbyVirtualMachinePoolData(document.RootElement);
            return new StandbyVirtualMachinePoolResource(_client, data);
        }
    }
}
