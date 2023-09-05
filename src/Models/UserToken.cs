// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.Giros.API.Models;

/// <summary>
/// Represents a user token.
/// </summary>
public record UserToken
{
    /// <summary>
    /// Gets or sets the access token.
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; init; }

    /// <summary>
    /// Gets or sets the token type.
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; init; }

    /// <summary>
    /// Gets or sets the whether the user must change the password.
    /// </summary>
    [JsonPropertyName("mustChangePassword")]
    public bool? IsChangePassword { get; init; }
}
