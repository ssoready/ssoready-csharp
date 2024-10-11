using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record ScimDirectory
{
    /// <summary>
    /// Unique identifier for this SCIM directory.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The organization this SCIM directory belongs to.
    /// </summary>
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; set; }

    /// <summary>
    /// Whether this is the primary SCIM directory for the organization.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// Base URL the Identity Provider uses to perform SCIM HTTP requests.
    ///
    /// SCIM base URLs are assigned by SSOReady, and need to be inputted into your customer's Identity Provider.
    /// </summary>
    [JsonPropertyName("scimBaseUrl")]
    public string? ScimBaseUrl { get; set; }

    /// <summary>
    /// Whether this SCIM directory has a bearer token assigned.
    ///
    /// SSOReady only stores a hash of the bearer token. To get a bearer token value, you must rotate this SCIM directory's
    /// bearer token.
    /// </summary>
    [JsonPropertyName("hasClientBearerToken")]
    public bool? HasClientBearerToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
