using System.Net.Http;
using System.Text.Json;
using System.Threading;
using SSOReady;
using SSOReady.Core;

#nullable enable

namespace SSOReady.Management;

public partial class SamlConnectionsClient
{
    private RawClient _client;

    internal SamlConnectionsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Lists SAML connections in an organization.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.SamlConnections.ListSamlConnectionsAsync(
    ///     new SamlConnectionsListSamlConnectionsRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<ListSamlConnectionsResponse> ListSamlConnectionsAsync(
        SamlConnectionsListSamlConnectionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.OrganizationId != null)
        {
            _query["organizationId"] = request.OrganizationId;
        }
        if (request.PageToken != null)
        {
            _query["pageToken"] = request.PageToken;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "v1/saml-connections",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ListSamlConnectionsResponse>(responseBody)!;
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
    /// Creates a SAML connection.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.SamlConnections.CreateSamlConnectionAsync(new SamlConnection());
    /// </code>
    /// </example>
    public async Task<CreateSamlConnectionResponse> CreateSamlConnectionAsync(
        SamlConnection request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "v1/saml-connections",
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
                return JsonUtils.Deserialize<CreateSamlConnectionResponse>(responseBody)!;
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
    /// Gets a SAML connection.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.SamlConnections.GetSamlConnectionAsync("id");
    /// </code>
    /// </example>
    public async Task<GetSamlConnectionResponse> GetSamlConnectionAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"v1/saml-connections/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetSamlConnectionResponse>(responseBody)!;
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
    /// Updates a SAML connection.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.SamlConnections.UpdateSamlConnectionAsync("id", new SamlConnection());
    /// </code>
    /// </example>
    public async Task<UpdateSamlConnectionResponse> UpdateSamlConnectionAsync(
        string id,
        SamlConnection request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethodExtensions.Patch,
                Path = $"v1/saml-connections/{id}",
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
                return JsonUtils.Deserialize<UpdateSamlConnectionResponse>(responseBody)!;
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
