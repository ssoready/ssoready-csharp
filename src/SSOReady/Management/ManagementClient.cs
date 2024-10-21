using SSOReady.Core;

#nullable enable

namespace SSOReady.Management;

public partial class ManagementClient
{
    private RawClient _client;

    internal ManagementClient(RawClient client)
    {
        _client = client;
        Organizations = new OrganizationsClient(_client);
        SamlConnections = new SamlConnectionsClient(_client);
        ScimDirectories = new ScimDirectoriesClient(_client);
        SetupUrls = new SetupUrlsClient(_client);
    }

    public OrganizationsClient Organizations { get; }

    public SamlConnectionsClient SamlConnections { get; }

    public ScimDirectoriesClient ScimDirectories { get; }

    public SetupUrlsClient SetupUrls { get; }
}
