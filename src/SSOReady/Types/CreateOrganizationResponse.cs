using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

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
