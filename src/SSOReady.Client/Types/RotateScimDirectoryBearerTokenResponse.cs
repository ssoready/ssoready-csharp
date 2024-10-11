using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record RotateScimDirectoryBearerTokenResponse
{
    /// <summary>
    /// The new, updated bearer token.
    ///
    /// Do not log or store this bearer token. It is an authentication token that your customer should securely input into
    /// their Identity Provider.
    /// </summary>
    [JsonPropertyName("bearerToken")]
    public string? BearerToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
