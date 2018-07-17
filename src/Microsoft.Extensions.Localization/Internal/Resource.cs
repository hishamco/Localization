// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

namespace Microsoft.Extensions.Localization.Internal
{
    public class Resource
    {
        public string Culture { get; }

        public string Key { get; }

        public string Value { get; }

        public Resource(string culture, string key, string value)
        {
            Culture = culture;
            Key = key;
            Value = value;
        }
    }
}