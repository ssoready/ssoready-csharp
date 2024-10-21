using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record GetSamlRedirectUrlResponse
{
    /// <summary>
    /// Redirect your user to this URL to start a SAML login.
    /// </summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
