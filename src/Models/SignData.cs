// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents a signature data.
/// </summary>
public record SignData
{
    /// <summary>
    /// Gets or sets the Base64 encoded content.
    /// </summary>
    public required string ContentAsBase64 { get; init; }
}
