// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.Internal
{
    internal static partial class ClosedGenericMatcher
    {
        public static System.Type ExtractGenericInterface(System.Type queryType, System.Type interfaceType) { throw null; }
    }
}

namespace Microsoft.AspNetCore.Mvc.ModelBinding
{
    public partial class ModelStateDictionary
    {
        internal const int DefaultMaxRecursionDepth = 32;

        internal int? MaxValidationDepth { get; set; }
        internal int? MaxStateDepth { get; set; }
    }
}