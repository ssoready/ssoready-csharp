using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record CreateSamlConnectionResponse
{
    /// <summary>
    /// The created SAML connection.
    /// </summary>
    [JsonPropertyName("samlConnection")]
    public SamlConnection? SamlConnection { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
