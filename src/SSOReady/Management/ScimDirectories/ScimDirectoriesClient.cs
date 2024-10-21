using System.Net.Http;
using System.Text.Json;
using System.Threading;
using SSOReady;
using SSOReady.Core;

#nullable enable

namespace SSOReady.Management;

public partial class ScimDirectoriesClient
{
    private RawClient _client;

    internal ScimDirectoriesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets a list of SCIM directories in an organization.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.ScimDirectories.ListScimDirectoriesAsync(
    ///     new ScimDirectoriesListScimDirectoriesRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<ListScimDirectoriesResponse> ListScimDirectoriesAsync(
        ScimDirectoriesListScimDirectoriesRequest request,
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
                Path = "v1/scim-directories",
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
                return JsonUtils.Deserialize<ListScimDirectoriesResponse>(responseBody)!;
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
    /// Creates a SCIM directory.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.ScimDirectories.CreateScimDirectoryAsync(new ScimDirectory());
    /// </code>
    /// </example>
    public async Task<CreateScimDirectoryResponse> CreateScimDirectoryAsync(
        ScimDirectory request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "v1/scim-directories",
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
                return JsonUtils.Deserialize<CreateScimDirectoryResponse>(responseBody)!;
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
    /// Gets a SCIM directory.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.ScimDirectories.GetScimDirectoryAsync("id");
    /// </code>
    /// </example>
    public async Task<GetScimDirectoryResponse> GetScimDirectoryAsync(
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
                Path = $"v1/scim-directories/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetScimDirectoryResponse>(responseBody)!;
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
    /// Updates a SCIM directory.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.ScimDirectories.UpdateScimDirectoryAsync("id", new ScimDirectory());
    /// </code>
    /// </example>
    public async Task<UpdateScimDirectoryResponse> UpdateScimDirectoryAsync(
        string id,
        ScimDirectory request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethodExtensions.Patch,
                Path = $"v1/scim-directories/{id}",
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
                return JsonUtils.Deserialize<UpdateScimDirectoryResponse>(responseBody)!;
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
    /// Rotates a SCIM directory's bearer token.
    ///
    /// Every SCIM directory has a bearer token that SSOReady uses to authenticate requests sent from your customer's
    /// Identity Provider. These bearer tokens are assigned by SSOReady, and are secret. Newly-created SCIM directories do
    /// not have any bearer token at all; you must use this endpoint to get an initial value.
    ///
    /// Rotating a SCIM directory bearer token immediately invalidates the previous bearer token, if any. Your customer
    /// will need to update their SCIM configuration with the new value to make SCIM syncing work again.
    ///
    /// SSOReady only stores the hash of these bearer tokens. If your customer has lost their copy, you must use this
    /// endpoint to generate a new one.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Management.ScimDirectories.RotateScimDirectoryBearerTokenAsync("id");
    /// </code>
    /// </example>
    public async Task<RotateScimDirectoryBearerTokenResponse> RotateScimDirectoryBearerTokenAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"v1/scim-directories/{id}/rotate-bearer-token",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<RotateScimDirectoryBearerTokenResponse>(responseBody)!;
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
