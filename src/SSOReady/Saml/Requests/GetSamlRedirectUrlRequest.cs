using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record GetSamlRedirectUrlRequest
{
    /// <summary>
    /// The SAML connection to start a SAML login for.
    ///
    ///  One of `samlConnectionId`, `organizationId`, or `organizationExternalId` must be specified.
    /// </summary>
    [JsonPropertyName("samlConnectionId")]
    public string? SamlConnectionId { get; set; }

    /// <summary>
    /// The ID of the organization to start a SAML login for.
    ///
    ///  The primary SAML connection in this organization will be used for logins.
    ///
    ///  One of `samlConnectionId`, `organizationId`, or `organizationExternalId` must be specified.
    /// </summary>
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; set; }

    /// <summary>
    /// The `externalId` of the organization to start a SAML login for.
    ///
    ///  The primary SAML connection in this organization will be used for logins.
    ///
    ///  One of `samlConnectionId`, `organizationId`, or `organizationExternalId` must be specified.
    /// </summary>
    [JsonPropertyName("organizationExternalId")]
    public string? OrganizationExternalId { get; set; }

    /// <summary>
    /// This string will be returned back to you when you redeem this login's SAML access code.
    ///
    ///  You can do anything you like with this `state`, but the most common use-case is to keep track of where to redirect
    ///  your user back to after logging in with SAML.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
