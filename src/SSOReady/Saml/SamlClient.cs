using System.Net.Http;
using System.Text.Json;
using System.Threading;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public partial class SamlClient
{
    private RawClient _client;

    internal SamlClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Exchanges a SAML access code for details about your user's SAML login details.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Saml.RedeemSamlAccessCodeAsync(
    ///     new RedeemSamlAccessCodeRequest { SamlAccessCode = "saml_access_code_..." }
    /// );
    /// </code>
    /// </example>
    public async Task<RedeemSamlAccessCodeResponse> RedeemSamlAccessCodeAsync(
        RedeemSamlAccessCodeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "v1/saml/redeem",
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
                return JsonUtils.Deserialize<RedeemSamlAccessCodeResponse>(responseBody)!;
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

    /// <summary>
    /// Gets a SAML initiation URL to redirect your users to.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Saml.GetSamlRedirectUrlAsync(
    ///     new GetSamlRedirectUrlRequest { OrganizationExternalId = "my_custom_external_id" }
    /// );
    /// </code>
    /// </example>
    public async Task<GetSamlRedirectUrlResponse> GetSamlRedirectUrlAsync(
        GetSamlRedirectUrlRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "v1/saml/redirect",
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
                return JsonUtils.Deserialize<GetSamlRedirectUrlResponse>(responseBody)!;
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
