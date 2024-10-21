using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record CreateSetupUrlResponse
{
    /// <summary>
    /// The one-time, short-lived self-serve setup URL.
    ///
    /// Do not log or store this URL. Because this URL is one-time, loading it yourself means your customer will not be
    /// able to load it after you.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
