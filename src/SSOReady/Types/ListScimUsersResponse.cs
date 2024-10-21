using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record ListScimUsersResponse
{
    /// <summary>
    /// List of SCIM users.
    /// </summary>
    [JsonPropertyName("scimUsers")]
    public IEnumerable<ScimUser>? ScimUsers { get; set; }

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
