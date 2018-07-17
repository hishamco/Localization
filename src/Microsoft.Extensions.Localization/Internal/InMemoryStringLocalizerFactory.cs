// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.Localization.Internal
{
public class InMemoryStringLocalizerFactory : IStringLocalizerFactory
{
    private readonly IList<Resource> _resources;

    public InMemoryStringLocalizerFactory(
        IList<Resource> resources)
    {
        _resources = resources ?? throw new ArgumentNullException(nameof(resources));
    }

    public IStringLocalizer Create(Type resourceSource)
        => new InMemoryStringLocalizer(_resources);

    public IStringLocalizer Create(string baseName, string location)
        => new InMemoryStringLocalizer(_resources);
}
}