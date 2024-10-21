using System.Net.Http;
using System.Text.Json;
using System.Threading;
using SSOReady.Core;

#nullable enable

namespace SSOReady;

public partial class ScimClient
{
    private RawClient _client;

    internal ScimClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets a list of SCIM groups in a SCIM directory.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Scim.ListScimGroupsAsync(
    ///     new ScimListScimGroupsRequest { OrganizationExternalId = "my_custom_external_id" }
    /// );
    /// </code>
    /// </example>
    public async Task<ListScimGroupsResponse> ListScimGroupsAsync(
        ScimListScimGroupsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.ScimDirectoryId != null)
        {
            _query["scimDirectoryId"] = request.ScimDirectoryId;
        }
        if (request.OrganizationId != null)
        {
            _query["organizationId"] = request.OrganizationId;
        }
        if (request.OrganizationExternalId != null)
        {
            _query["organizationExternalId"] = request.OrganizationExternalId;
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
                Path = "v1/scim/groups",
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
                return JsonUtils.Deserialize<ListScimGroupsResponse>(responseBody)!;
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
    /// Gets a SCIM group in a SCIM directory.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Scim.GetScimGroupAsync("scim_group_...");
    /// </code>
    /// </example>
    public async Task<GetScimGroupResponse> GetScimGroupAsync(
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
                Path = $"v1/scim/groups/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetScimGroupResponse>(responseBody)!;
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
    /// Gets a list of SCIM users in a SCIM directory.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Scim.ListScimUsersAsync(
    ///     new ScimListScimUsersRequest { OrganizationExternalId = "my_custom_external_id" }
    /// );
    /// </code>
    /// </example>
    public async Task<ListScimUsersResponse> ListScimUsersAsync(
        ScimListScimUsersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.ScimDirectoryId != null)
        {
            _query["scimDirectoryId"] = request.ScimDirectoryId;
        }
        if (request.OrganizationId != null)
        {
            _query["organizationId"] = request.OrganizationId;
        }
        if (request.OrganizationExternalId != null)
        {
            _query["organizationExternalId"] = request.OrganizationExternalId;
        }
        if (request.ScimGroupId != null)
        {
            _query["scimGroupId"] = request.ScimGroupId;
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
                Path = "v1/scim/users",
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
                return JsonUtils.Deserialize<ListScimUsersResponse>(responseBody)!;
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
    /// Gets a SCIM user.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Scim.GetScimUserAsync("scim_user_...");
    /// </code>
    /// </example>
    public async Task<GetScimUserResponse> GetScimUserAsync(
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
                Path = $"v1/scim/users/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetScimUserResponse>(responseBody)!;
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
