// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// The RoutingEnrichments.
/// </summary>
public partial class RoutingEnrichments : ProvisionableConstruct
{
    /// <summary>
    /// Gets the static             Please note
    /// Azure.ResourceManager.EventGrid.Models.StaticRoutingEnrichment is the
    /// base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.StaticStringRoutingEnrichment.
    /// </summary>
    public BicepList<StaticRoutingEnrichment> Static 
    {
        get { Initialize(); return _static!; }
        set { Initialize(); _static!.Assign(value); }
    }
    private BicepList<StaticRoutingEnrichment>? _static;

    /// <summary>
    /// Gets the dynamic.
    /// </summary>
    public BicepList<DynamicRoutingEnrichment> Dynamic 
    {
        get { Initialize(); return _dynamic!; }
        set { Initialize(); _dynamic!.Assign(value); }
    }
    private BicepList<DynamicRoutingEnrichment>? _dynamic;

    /// <summary>
    /// Creates a new RoutingEnrichments.
    /// </summary>
    public RoutingEnrichments()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of RoutingEnrichments.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _static = DefineListProperty<StaticRoutingEnrichment>("Static", ["static"]);
        _dynamic = DefineListProperty<DynamicRoutingEnrichment>("Dynamic", ["dynamic"]);
    }
}
