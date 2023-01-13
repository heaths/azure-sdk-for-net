// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

461
using System;
using System.Security.Cryptography;

namespace Azure.Core
{
    internal static partial class LightweightPkcs8Decoder
    {
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CA1801 // Review unused parameters
        public static ECDsa DecodeECDsaPkcs8(byte[] pkcs8Bytes, ECDsa publicKey)
        {
            throw new PlatformNotSupportedException("The current platform does not support reading an ECDsa private key from a PEM file");
        }
#pragma warning restore CA1801 // Review unused parameters
#pragma warning restore IDE0060 // Remove unused parameter
    }
}
#endif
