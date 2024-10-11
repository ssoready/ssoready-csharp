using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record GetScimDirectoryResponse
{
    /// <summary>
    /// The requested SCIM directory.
    /// </summary>
    [JsonPropertyName("scimDirectory")]
    public ScimDirectory? ScimDirectory { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
