using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady.Management;

public record CreateSetupUrlRequest
{
    /// <summary>
    /// The organization that the setup URL is for.
    /// </summary>
    [JsonPropertyName("organizationId")]
    public string? OrganizationId { get; set; }

    /// <summary>
    /// Whether the setup URL lets the user manage SAML connections.
    /// </summary>
    [JsonPropertyName("canManageSaml")]
    public bool? CanManageSaml { get; set; }

    /// <summary>
    /// Whether the setup URL lets the user manage SCIM directories.
    /// </summary>
    [JsonPropertyName("canManageScim")]
    public bool? CanManageScim { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
