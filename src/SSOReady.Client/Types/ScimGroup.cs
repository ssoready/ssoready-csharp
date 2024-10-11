using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record ScimGroup
{
    /// <summary>
    /// Unique identifier for this SCIM group.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// SCIM directory this SCIM group belongs to.
    /// </summary>
    [JsonPropertyName("scimDirectoryId")]
    public string? ScimDirectoryId { get; set; }

    /// <summary>
    /// A human-friendly name for the SCIM group.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Whether the SCIM group has been deleted or deprovisioned from its SCIM directory.
    ///
    /// Identity Providers are inconsistent about reliably deleting SCIM groups. Many Identity Providers will deprovision
    /// the users inside a group, but not the group itself. For this reason, it's typical to ignore this field until a
    /// specific need arises.
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// Arbitrary, potentially nested, attributes the Identity Provider included about the group.
    ///
    /// Identity Providers are inconsistent about supporting sending custom attributes on groups. For this reason, it's
    /// typical to not rely on them until a specific need arises.
    /// </summary>
    [JsonPropertyName("attributes")]
    public object? Attributes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
