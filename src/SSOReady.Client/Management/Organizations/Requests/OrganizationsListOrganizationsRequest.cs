using SSOReady.Client.Core;

#nullable enable

namespace SSOReady.Client.Management;

public record OrganizationsListOrganizationsRequest
{
    /// <summary>
    /// Pagination token. Leave empty to get the first page of results.
    /// </summary>
    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
