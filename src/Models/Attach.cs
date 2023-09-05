// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents an attachment.
/// </summary>
public record Attach
{
    /// <summary>
    /// Gets or sets the document identifier.
    /// </summary>
    public string? DocumentId { get; init; }

    /// <summary>
    /// Gets or sets the document type code.
    /// </summary>
    public string? DocTypeCode { get; init; }

    /// <summary>
    /// Gets or sets the system code.
    /// </summary>
    public string? SystemCode { get; init; }

    /// <summary>
    /// Gets or sets the file identifier.
    /// </summary>
    public string? FileUUID { get; init; }

    /// <summary>
    /// Gets or sets the name of the attachment.
    /// </summary>
    public string? AttachName { get; init; }

    /// <summary>
    /// Gets or sets the external identifier of the attachment.
    /// </summary>
    public string? ExtId { get; init; }
}
