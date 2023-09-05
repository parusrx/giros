// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents a credentials.
/// </summary>
[XmlRoot("credentials")]
public record Credentials
{
    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    [XmlElement("username")]
    public required string Username { get; init; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    [XmlElement("password")]
    public required string Password { get; init; }

    /// <summary>
    /// Gets or sets the company identifier.
    /// </summary>
    [XmlElement("companyId")]
    public required string CompanyId { get; init; }

    /// <summary>
    /// Gets or sets the juridical person identifier.
    /// </summary>
    [XmlElement("juridicalPersonId")]
    public required string JuridicalPersonId { get; init; }
}
