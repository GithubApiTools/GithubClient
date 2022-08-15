#### [GithubClient](index.md 'index')
### [GithubClient.Repositories](GithubClient.Repositories.md 'GithubClient.Repositories').[Repository](GithubClient.Repositories.Repository.md 'GithubClient.Repositories.Repository')

## Repository.GetOrgEndpoint(string, int, int, string, string) Method

```csharp
public static System.Uri GetOrgEndpoint(string Org, int PerPage, int Page, string Type, string Direction);
```
#### Parameters

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int,string,string).Org'></a>

`Org` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int,string,string).PerPage'></a>

`PerPage` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of results per page (max 100).

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int,string,string).Page'></a>

`Page` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Page number of the results to fetch

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int,string,string).Type'></a>

`Type` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Specifies the types of repositories you want returned.

<a name='GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int,string,string).Direction'></a>

`Direction` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The order to sort by. Default: asc

#### Returns
[System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')