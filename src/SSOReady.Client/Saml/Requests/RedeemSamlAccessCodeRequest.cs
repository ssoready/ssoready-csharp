using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record RedeemSamlAccessCodeRequest
{
    /// <summary>
    /// The SAML access code to redeem.
    /// </summary>
    [JsonPropertyName("samlAccessCode")]
    public string? SamlAccessCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
