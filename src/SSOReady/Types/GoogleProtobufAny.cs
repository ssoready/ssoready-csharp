using System.Text.Json.Serialization;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public record GoogleProtobufAny
{
    /// <summary>
    /// The type of the serialized message.
    /// </summary>
    [JsonPropertyName("@type")]
    public string? Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
