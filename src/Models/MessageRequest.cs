// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents a message request.
/// </summary>
[XmlRoot("messageRequest")]
public class MessageRequest
{
    /// <summary>
    /// Gets or sets the credentials.
    /// </summary>
    [XmlElement("credentials")]
    public required Credentials Credentials { get; init; }
}
