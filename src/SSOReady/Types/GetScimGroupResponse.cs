using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record GetScimGroupResponse
{
    /// <summary>
    /// The requested SCIM group.
    /// </summary>
    [JsonPropertyName("scimGroup")]
    public ScimGroup? ScimGroup { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
