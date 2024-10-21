using SSOReady.Core;
using SSOReady.Management;

#nullable enable

namespace SSOReady;

public partial class SSOReady
{
    private RawClient _client;

    public SSOReady(string? apiKey = null, ClientOptions? clientOptions = null)
    {
        apiKey ??= GetFromEnvironmentOrThrow(
            "SSOREADY_API_KEY",
            "Please pass in apiKey or set the environment variable SSOREADY_API_KEY."
        );
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {apiKey}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "SSOReady" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "SSOReady/0.1.2" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
        Saml = new SamlClient(_client);
        Scim = new ScimClient(_client);
        Management = new ManagementClient(_client);
    }

    public SamlClient Saml { get; init; }

    public ScimClient Scim { get; init; }

    public ManagementClient Management { get; init; }

    private static string GetFromEnvironmentOrThrow(string env, string message)
    {
        return Environment.GetEnvironmentVariable(env) ?? throw new Exception(message);
    }
}
