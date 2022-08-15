#### [GithubClient](index.md 'index')
### [GithubClient.Repositories](GithubClient.Repositories.md 'GithubClient.Repositories').[Repository](GithubClient.Repositories.Repository.md 'GithubClient.Repositories.Repository')

## Repository.GetOrgEndpoint(string, int, int) Method

```csharp
public static System.Uri GetOrgEndpoint(string Org, int PerPage, int Page);
```
#### Parameters

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int).Org'></a>

`Org` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int).PerPage'></a>

`PerPage` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of results per page (max 100).

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int).Page'></a>

`Page` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Page number of the results to fetch

#### Returns
[System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')