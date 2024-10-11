using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record ListScimGroupsResponse
{
    /// <summary>
    /// List of SCIM groups.
    /// </summary>
    [JsonPropertyName("scimGroups")]
    public IEnumerable<ScimGroup>? ScimGroups { get; set; }

    /// <summary>
    /// Value to use as `pageToken` for the next page of data. Empty if there is no more data.
    /// </summary>
    [JsonPropertyName("nextPageToken")]
    public string? NextPageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
