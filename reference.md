# Reference
## Saml
<details><summary><code>client.Saml.<a href="/src/SSOReady/Saml/SamlClient.cs">RedeemSamlAccessCodeAsync</a>(RedeemSamlAccessCodeRequest { ... }) -> RedeemSamlAccessCodeResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exchanges a SAML access code for details about your user's SAML login details.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Saml.RedeemSamlAccessCodeAsync(
    new RedeemSamlAccessCodeRequest { SamlAccessCode = "saml_access_code_..." }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RedeemSamlAccessCodeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Saml.<a href="/src/SSOReady/Saml/SamlClient.cs">GetSamlRedirectUrlAsync</a>(GetSamlRedirectUrlRequest { ... }) -> GetSamlRedirectUrlResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a SAML initiation URL to redirect your users to.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Saml.GetSamlRedirectUrlAsync(
    new GetSamlRedirectUrlRequest { OrganizationExternalId = "my_custom_external_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSamlRedirectUrlRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Scim
<details><summary><code>client.Scim.<a href="/src/SSOReady/Scim/ScimClient.cs">ListScimGroupsAsync</a>(ScimListScimGroupsRequest { ... }) -> ListScimGroupsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of SCIM groups in a SCIM directory.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Scim.ListScimGroupsAsync(
    new ScimListScimGroupsRequest { OrganizationExternalId = "my_custom_external_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ScimListScimGroupsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Scim.<a href="/src/SSOReady/Scim/ScimClient.cs">GetScimGroupAsync</a>(id) -> GetScimGroupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a SCIM group in a SCIM directory.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Scim.GetScimGroupAsync("scim_group_...");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the SCIM group to get.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Scim.<a href="/src/SSOReady/Scim/ScimClient.cs">ListScimUsersAsync</a>(ScimListScimUsersRequest { ... }) -> ListScimUsersResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of SCIM users in a SCIM directory.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Scim.ListScimUsersAsync(
    new ScimListScimUsersRequest { OrganizationExternalId = "my_custom_external_id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ScimListScimUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Scim.<a href="/src/SSOReady/Scim/ScimClient.cs">GetScimUserAsync</a>(id) -> GetScimUserResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a SCIM user.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Scim.GetScimUserAsync("scim_user_...");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the SCIM user to get.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Management Organizations
<details><summary><code>client.Management.Organizations.<a href="/src/SSOReady/Management/Organizations/OrganizationsClient.cs">ListOrganizationsAsync</a>(OrganizationsListOrganizationsRequest { ... }) -> ListOrganizationsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of organizations.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.Organizations.ListOrganizationsAsync(
    new OrganizationsListOrganizationsRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrganizationsListOrganizationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.Organizations.<a href="/src/SSOReady/Management/Organizations/OrganizationsClient.cs">CreateOrganizationAsync</a>(Organization { ... }) -> CreateOrganizationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.Organizations.CreateOrganizationAsync(new Organization());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Organization` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.Organizations.<a href="/src/SSOReady/Management/Organizations/OrganizationsClient.cs">GetOrganizationAsync</a>(id) -> GetOrganizationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets an organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.Organizations.GetOrganizationAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the organization to get.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.Organizations.<a href="/src/SSOReady/Management/Organizations/OrganizationsClient.cs">UpdateOrganizationAsync</a>(id, Organization { ... }) -> UpdateOrganizationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.Organizations.UpdateOrganizationAsync("id", new Organization());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the organization to update.
    
</dd>
</dl>

<dl>
<dd>

**request:** `Organization` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Management SamlConnections
<details><summary><code>client.Management.SamlConnections.<a href="/src/SSOReady/Management/SamlConnections/SamlConnectionsClient.cs">ListSamlConnectionsAsync</a>(SamlConnectionsListSamlConnectionsRequest { ... }) -> ListSamlConnectionsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lists SAML connections in an organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.SamlConnections.ListSamlConnectionsAsync(
    new SamlConnectionsListSamlConnectionsRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SamlConnectionsListSamlConnectionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.SamlConnections.<a href="/src/SSOReady/Management/SamlConnections/SamlConnectionsClient.cs">CreateSamlConnectionAsync</a>(SamlConnection { ... }) -> CreateSamlConnectionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a SAML connection.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.SamlConnections.CreateSamlConnectionAsync(new SamlConnection());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SamlConnection` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.SamlConnections.<a href="/src/SSOReady/Management/SamlConnections/SamlConnectionsClient.cs">GetSamlConnectionAsync</a>(id) -> GetSamlConnectionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a SAML connection.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.SamlConnections.GetSamlConnectionAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the SAML connection to get.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.SamlConnections.<a href="/src/SSOReady/Management/SamlConnections/SamlConnectionsClient.cs">UpdateSamlConnectionAsync</a>(id, SamlConnection { ... }) -> UpdateSamlConnectionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a SAML connection.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.SamlConnections.UpdateSamlConnectionAsync("id", new SamlConnection());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — The ID of the SAML connection to update.
    
</dd>
</dl>

<dl>
<dd>

**request:** `SamlConnection` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Management ScimDirectories
<details><summary><code>client.Management.ScimDirectories.<a href="/src/SSOReady/Management/ScimDirectories/ScimDirectoriesClient.cs">ListScimDirectoriesAsync</a>(ScimDirectoriesListScimDirectoriesRequest { ... }) -> ListScimDirectoriesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of SCIM directories in an organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.ScimDirectories.ListScimDirectoriesAsync(
    new ScimDirectoriesListScimDirectoriesRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ScimDirectoriesListScimDirectoriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.ScimDirectories.<a href="/src/SSOReady/Management/ScimDirectories/ScimDirectoriesClient.cs">CreateScimDirectoryAsync</a>(ScimDirectory { ... }) -> CreateScimDirectoryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a SCIM directory.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.ScimDirectories.CreateScimDirectoryAsync(new ScimDirectory());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ScimDirectory` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.ScimDirectories.<a href="/src/SSOReady/Management/ScimDirectories/ScimDirectoriesClient.cs">GetScimDirectoryAsync</a>(id) -> GetScimDirectoryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a SCIM directory.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.ScimDirectories.GetScimDirectoryAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — The ID of the SCIM directory.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.ScimDirectories.<a href="/src/SSOReady/Management/ScimDirectories/ScimDirectoriesClient.cs">UpdateScimDirectoryAsync</a>(id, ScimDirectory { ... }) -> UpdateScimDirectoryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a SCIM directory.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.ScimDirectories.UpdateScimDirectoryAsync("id", new ScimDirectory());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — The ID of the SCIM directory to update.
    
</dd>
</dl>

<dl>
<dd>

**request:** `ScimDirectory` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Management.ScimDirectories.<a href="/src/SSOReady/Management/ScimDirectories/ScimDirectoriesClient.cs">RotateScimDirectoryBearerTokenAsync</a>(id) -> RotateScimDirectoryBearerTokenResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Rotates a SCIM directory's bearer token.

Every SCIM directory has a bearer token that SSOReady uses to authenticate requests sent from your customer's
Identity Provider. These bearer tokens are assigned by SSOReady, and are secret. Newly-created SCIM directories do
not have any bearer token at all; you must use this endpoint to get an initial value.

Rotating a SCIM directory bearer token immediately invalidates the previous bearer token, if any. Your customer
will need to update their SCIM configuration with the new value to make SCIM syncing work again.

SSOReady only stores the hash of these bearer tokens. If your customer has lost their copy, you must use this
endpoint to generate a new one.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.ScimDirectories.RotateScimDirectoryBearerTokenAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — The ID of the SCIM directory whose bearer token to rotate.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Management SetupUrls
<details><summary><code>client.Management.SetupUrls.<a href="/src/SSOReady/Management/SetupUrls/SetupUrlsClient.cs">CreateSetupUrlAsync</a>(CreateSetupUrlRequest { ... }) -> CreateSetupUrlResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a short-lived self-serve setup URL that you can send to your customer.

Setup URLs let your customer configure their SAML settings, SCIM settings, or both.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Management.SetupUrls.CreateSetupUrlAsync(new CreateSetupUrlRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateSetupUrlRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
