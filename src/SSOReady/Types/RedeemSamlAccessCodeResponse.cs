using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record RedeemSamlAccessCodeResponse
{
    /// <summary>
    /// The user's email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// The `state` you provided when getting a SAML initiation URL, if any.
    ///
    /// If your user logged in to your product using Identity Provider-initiated SAML (e.g. they clicked on your app inside
    /// their corporate Okta dashboard), then `state` will be empty.
    ///
    /// SSOReady validates the authenticity of non-empty `state` values. You do not need to implement your own CSRF on top
    /// of it, but doing so anyway will have no bad consequences.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Arbitrary key-value pairs the Identity Provider included about the user.
    ///
    /// Typically, these `attributes` are used to pass along the user's first/last name, or whether they should be
    /// considered an admin within their company.
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// The ID of the organization this user belongs to.
    /// </summary>
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; set; }

    /// <summary>
    /// The `externalId`, if any, of the organization this user belongs to.
    /// </summary>
    [JsonPropertyName("organizationExternalId")]
    public string? OrganizationExternalId { get; set; }

    /// <summary>
    /// A unique identifier of this particular SAML login. It is not a secret. You can safely log it.
    ///
    /// SSOReady maintains an audit log of every SAML login. Use this SAML flow ID to find this login in the audit logs.
    /// </summary>
    [JsonPropertyName("samlFlowId")]
    public string? SamlFlowId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
