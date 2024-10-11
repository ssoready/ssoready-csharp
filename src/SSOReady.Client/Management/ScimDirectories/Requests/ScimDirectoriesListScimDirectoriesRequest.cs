using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client.Management;

public record ScimDirectoriesListScimDirectoriesRequest
{
    /// <summary>
    /// The organization the SCIM directories belong to.
    /// </summary>
    public string? OrganizationId { get; set; }

    /// <summary>
    /// Pagination token. Leave empty to get the first page of results.
    /// </summary>
    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
