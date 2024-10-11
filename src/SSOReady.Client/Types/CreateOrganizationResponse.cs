using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record CreateOrganizationResponse
{
    /// <summary>
    /// The created organization.
    /// </summary>
    [JsonPropertyName("organization")]
    public Organization? Organization { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
