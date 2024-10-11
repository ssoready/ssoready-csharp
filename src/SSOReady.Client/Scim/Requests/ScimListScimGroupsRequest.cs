using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client;

public record ScimListScimGroupsRequest
{
    /// <summary>
    /// The SCIM directory to list from.
    ///
    /// One of `scimDirectoryId`, `organizationId`, or `organizationExternalId` must be specified.
    /// </summary>
    public string? ScimDirectoryId { get; set; }

    /// <summary>
    /// The ID of the organization to list from. The primary SCIM directory of this organization is used.
    ///
    /// One of `scimDirectoryId`, `organizationId`, or `organizationExternalId` must be specified.
    /// </summary>
    public string? OrganizationId { get; set; }

    /// <summary>
    /// The `externalId` of the organization to list from. The primary SCIM directory of this organization is used.
    ///
    /// One of `scimDirectoryId`, `organizationId`, or `organizationExternalId` must be specified.
    /// </summary>
    public string? OrganizationExternalId { get; set; }

    /// <summary>
    /// Pagination token. Leave empty to get the first page of results.
    /// </summary>
    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
