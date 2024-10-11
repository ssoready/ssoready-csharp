using System.Text.Json.Serialization;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record Status
{
    /// <summary>
    /// The status code, which should be an enum value of [google.rpc.Code][google.rpc.code].
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.status.details] field, or localized by the client.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
    /// </summary>
    [JsonPropertyName("details")]
    public IEnumerable<GoogleProtobufAny>? Details { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
