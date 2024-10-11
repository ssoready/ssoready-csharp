using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record UpdateSamlConnectionResponse
{
    /// <summary>
    /// The updated SAML connection.
    /// </summary>
    [JsonPropertyName("samlConnection")]
    public SamlConnection? SamlConnection { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
