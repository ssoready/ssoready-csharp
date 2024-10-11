using System.Net.Http;
using System.Text.Json;
using System.Threading;
using SSOReady.Client;
using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client.Management;

public partial class OrganizationsClient
{
    private RawClient _client;

    internal OrganizationsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets a list of organizations.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.Organizations.ListOrganizationsAsync(
    ///     new OrganizationsListOrganizationsRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<ListOrganizationsResponse> ListOrganizationsAsync(
        OrganizationsListOrganizationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PageToken != null)
        {
            _query["pageToken"] = request.PageToken;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "v1/organizations",
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
                return JsonUtils.Deserialize<ListOrganizationsResponse>(responseBody)!;
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
    /// Creates an organization.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.Organizations.CreateOrganizationAsync(new Organization());
    /// </code>
    /// </example>
    public async Task<CreateOrganizationResponse> CreateOrganizationAsync(
        Organization request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "v1/organizations",
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
                return JsonUtils.Deserialize<CreateOrganizationResponse>(responseBody)!;
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
    /// Gets an organization.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.Organizations.GetOrganizationAsync("id");
    /// </code>
    /// </example>
    public async Task<GetOrganizationResponse> GetOrganizationAsync(
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
                Path = $"v1/organizations/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetOrganizationResponse>(responseBody)!;
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
    /// Updates an organization.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.Organizations.UpdateOrganizationAsync("id", new Organization());
    /// </code>
    /// </example>
    public async Task<UpdateOrganizationResponse> UpdateOrganizationAsync(
        string id,
        Organization request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethodExtensions.Patch,
                Path = $"v1/organizations/{id}",
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
                return JsonUtils.Deserialize<UpdateOrganizationResponse>(responseBody)!;
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
