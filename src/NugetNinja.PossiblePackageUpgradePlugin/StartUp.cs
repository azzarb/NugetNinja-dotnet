﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.NugetNinja.Core;
using Microsoft.NugetNinja.Core;

namespace Microsoft.NugetNinja.PossiblePackageUpgradePlugin;

public class StartUp : IStartUp
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<Extractor>();
        services.AddTransient<ProjectsEnumerator>();
        services.AddTransient<PackageReferenceUpgradeDetector>();
    }
}
