// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents a ticket.
/// </summary>
public record Ticket
{
    /// <summary>
    /// Gets or sets the tax code of the organization.
    /// </summary>
    [JsonPropertyName("Org_Taxcode")]
    public string? Taxcode { get; init; }

    /// <summary>
    /// Gets or sets the code of the organization.
    /// </summary>
    [JsonPropertyName("Org_Code_FK")]
    public string? Code { get; init; }

    /// <summary>
    /// Gets or sets the KPP of the organization.
    /// </summary>
    [JsonPropertyName("Org_KPP")]
    public string? Kpp { get; init; }

    /// <summary>
    /// Gets or sets the document identifier.
    /// </summary>
    [JsonPropertyName("Document_ID")]
    public string? DocumentId { get; init; }

    /// <summary>
    /// Gets or sets the document class.
    /// </summary>
    [JsonPropertyName("Class")]
    public string? Class { get; init; }

    /// <summary>
    /// Gets or sets the status of the document.
    /// </summary>
    [JsonPropertyName("Status")]
    public string? Status { get; init; }

    /// <summary>
    /// Gets or sets the record timestamp.
    /// </summary>
    [JsonPropertyName("RecordTimeStamp")]
    public DateTime? RecordTimeStamp { get; init; }

    /// <summary>
    /// Gets or sets the result of the validation sign.
    /// </summary>
    [JsonPropertyName("ResultValidationSign")]
    public bool? ResultValidationSign { get; init; }

    /// <summary>
    /// Gets or sets the sign of the ticket.
    /// </summary>
    [JsonPropertyName("Sign")]
    public string? Sign { get; init; }
}
