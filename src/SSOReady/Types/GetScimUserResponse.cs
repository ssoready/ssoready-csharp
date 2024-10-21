using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record GetScimUserResponse
{
    /// <summary>
    /// The requested SCIM user.
    /// </summary>
    [JsonPropertyName("scimUser")]
    public ScimUser? ScimUser { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
