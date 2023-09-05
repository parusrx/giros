// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents a message response.
/// </summary>
public record MessageResponse
{
    /// <summary>
    /// Gets or sets the response.
    /// </summary>
    [JsonPropertyName("response")]
    public required string Response { get; init; }
}
