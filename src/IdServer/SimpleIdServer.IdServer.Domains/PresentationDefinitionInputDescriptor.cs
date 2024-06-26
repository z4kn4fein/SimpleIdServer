﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace SimpleIdServer.IdServer.Domains;

public class PresentationDefinitionInputDescriptor
{
    [JsonIgnore]
    public string Id { get; set; } = null!;
    /// <summary>
    /// The value of the id property MUST be a string that does not conflict with the id of another Input Descriptor Object in the same Presentation Definition.
    /// </summary>
    [JsonPropertyName("id")]
    public string PublicId { get; set; } = null!;
    /// <summary>
    /// If present, its value SHOULD be a human-friendly name that describes what the target schema represents.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Name { get; set; } = null;
    /// <summary>
    /// If present, its value MUST be a string that describes the purpose for which the Claim's data is being requested.
    /// </summary>
    [JsonPropertyName("purpose")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Purpose { get; set; } = null;
    /// <summary>
    /// If present, its value MUST be an object with one or more properties matching the registered Claim Format Designations (e.g., jwt, jwt_vc, jwt_vp, etc.).
    /// </summary>
    [JsonIgnore]
    public List<PresentationDefinitionFormat> Format { get; set; } = new List<PresentationDefinitionFormat>();
    /// <summary>
    /// Fields SHALL be processed forward from 0-index, so if a Verifier desires to reduce processing by checking the most defining characteristics of a credential (e.g the type or schema of a credential) implementers SHOULD order these field checks before all others to ensure earliest termination of evaluation. 
    /// </summary>
    [JsonIgnore]
    public List<PresentationDefinitionInputDescriptorConstraint> Constraints { get; set; } = new List<PresentationDefinitionInputDescriptorConstraint>();

    [JsonPropertyName("format")]
    public JsonObject SerializedFormat
    {
        get
        {
            return PresentationDefinitionFormat.Serialize(Format);
        }
    }

    [JsonPropertyName("constraints")]
    public JsonObject SerializedConstraints
    {
        get
        {
            return PresentationDefinitionInputDescriptorConstraint.Serialize(Constraints);
        }
    }
}