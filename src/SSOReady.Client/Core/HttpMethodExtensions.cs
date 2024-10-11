using System.Net.Http;

namespace SSOReady.Client.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
