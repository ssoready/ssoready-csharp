using System.Net.Http;
using System.Text.Json;
using System.Threading;
using SSOReady.Client;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client.Management;

public partial class SetupUrlsClient
{
    private RawClient _client;

    internal SetupUrlsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a short-lived self-serve setup URL that you can send to your customer.
    ///
    /// Setup URLs let your customer configure their SAML settings, SCIM settings, or both.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.SetupUrls.CreateSetupUrlAsync(new CreateSetupUrlRequest());
    /// </code>
    /// </example>
    public async Task<CreateSetupUrlResponse> CreateSetupUrlAsync(
        CreateSetupUrlRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "v1/setup-urls",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CreateSetupUrlResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new SSOReadyException("Failed to deserialize response", e);
            }
        }

        throw new SSOReadyApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
