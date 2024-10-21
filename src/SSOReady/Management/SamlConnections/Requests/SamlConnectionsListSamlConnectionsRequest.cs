using SSOReady.Core;

#nullable enable

namespace SSOReady.Management;

public record SamlConnectionsListSamlConnectionsRequest
{
    /// <summary>
    /// The organization the SAML connections belong to.
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
