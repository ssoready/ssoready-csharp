using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record ListSamlConnectionsResponse
{
    /// <summary>
    /// The list of SAML connections.
    /// </summary>
    [JsonPropertyName("samlConnections")]
    public IEnumerable<SamlConnection>? SamlConnections { get; set; }

    /// <summary>
    /// Value to use as `pageToken` for the next page of data. Empty if there is no more data.
    /// </summary>
    [JsonPropertyName("nextPageToken")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
