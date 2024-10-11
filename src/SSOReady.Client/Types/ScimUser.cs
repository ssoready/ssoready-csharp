using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record ScimUser
{
    /// <summary>
    /// Unique identifier for this SCIM user.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// SCIM directory this SCIM user belongs to.
    /// </summary>
    [JsonPropertyName("scimDirectoryId")]
    public string? ScimDirectoryId { get; set; }

    /// <summary>
    /// The SCIM user's email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// Whether the SCIM user has been deleted or deprovisioned from its SCIM directory.
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// Arbitrary, potentially nested, attributes the Identity Provider included about the user.
    ///
    /// Typically, these `attributes` are used to pass along the user's first/last name, or whether they should be
    /// considered an admin within their company.
    /// </summary>
    [JsonPropertyName("attributes")]
    public object? Attributes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
