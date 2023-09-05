// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents an attached file.
/// </summary>
public record AttachedFile
{
    /// <summary>
    /// Gets or sets the file name.
    /// </summary>
    public string? FileName { get; init; }

    /// <summary>
    /// Gets or sets the file content.
    /// </summary>
    public byte[]? Content { get; init; }
}
