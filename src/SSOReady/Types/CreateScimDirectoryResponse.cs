using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record CreateScimDirectoryResponse
{
    /// <summary>
    /// The updated SCIM directory.
    /// </summary>
    [JsonPropertyName("scimDirectory")]
    public ScimDirectory? ScimDirectory { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
