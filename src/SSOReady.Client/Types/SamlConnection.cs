using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record SamlConnection
{
    /// <summary>
    /// Unique identifier for this SAML connection.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The organization this SAML connection belongs to.
    /// </summary>
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; set; }

    /// <summary>
    /// Whether this is the primary SAML connection for the organization.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// URL to redirect to when initiating SAML flows.
    ///
    /// IDP redirect URLs are assigned by an Identity Provider, and need to be inputted into SSOReady.
    /// </summary>
    [JsonPropertyName("idpRedirectUrl")]
    public string? IdpRedirectUrl { get; set; }

    /// <summary>
    /// Certificate to authenticate SAML assertions. This is a PEM-encoded X.509 certificate.
    ///
    /// IDP certificates are assigned by an Identity Provider, and need to be inputted into SSOReady.
    /// </summary>
    [JsonPropertyName("idpCertificate")]
    public string? IdpCertificate { get; set; }

    /// <summary>
    /// Identifier for the identity provider when handling SAML operations.
    ///
    /// IDP entity IDs are assigned by an Identity Provider, and need to be inputted into SSOReady.
    /// </summary>
    [JsonPropertyName("idpEntityId")]
    public string? IdpEntityId { get; set; }

    /// <summary>
    /// Identifier for the SAML connection when handling SAML operations.
    ///
    /// SP entity IDs are assigned by SSOReady, and need to be inputted into your customer's Identity Provider.
    /// </summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }

    /// <summary>
    /// URL the Identity Provider redirects to when transmitting SAML assertions. Stands for "Service Provider Assertion
    /// Consumer Service" URL.
    ///
    /// SP ACS URLs are assigned by SSOReady, and need to be inputted into your customer's Identity Provider.
    /// </summary>
    [JsonPropertyName("spAcsUrl")]
    public string? SpAcsUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
