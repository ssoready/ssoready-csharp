using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record Organization
{
    /// <summary>
    /// Unique identifier for this organization.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The environment this organization belongs to.
    /// </summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    /// <summary>
    /// An optional human-friendly name for this organization.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// An identifier you can attach to an organization. Meant to be used to correlate an SSOReady organization to your
    /// internal equivalent concept.
    ///
    /// External IDs are unique within an environment. No two organizations in the same environment can have
    /// the same external ID.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// A list of domains that users from this organization use.
    ///
    /// SAML connections and SCIM directories within this organization will only produce users whose email are included in
    /// `domains`. SSOReady will reject SAML and SCIM users that do not fall within `domains`.
    /// </summary>
    [JsonPropertyName("domains")]
    public IEnumerable<string>? Domains { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
