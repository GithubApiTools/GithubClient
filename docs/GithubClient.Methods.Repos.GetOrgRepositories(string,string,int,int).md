#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Repos](GithubClient.Methods.Repos 'GithubClient.Methods.Repos')

## Repos.GetOrgRepositories(string, string, int, int) Method

Returns a repository object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<GithubClient.Repositories.Repository>>? GetOrgRepositories(string PAT, string Org, int PerPage=30, int Page=1);
```
#### Parameters

<a name='GithubClient.Methods.Repos.GetOrgRepositories(string,string,int,int).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Repos.GetOrgRepositories(string,string,int,int).Org'></a>

`Org` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Methods.Repos.GetOrgRepositories(string,string,int,int).PerPage'></a>

`PerPage` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of results per page (max 100).

<a name='GithubClient.Methods.Repos.GetOrgRepositories(string,string,int,int).Page'></a>

`Page` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Page number of the results to fetch

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Repository](GithubClient.Repositories.Repository 'GithubClient.Repositories.Repository')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A collection of repository objects

### See Also
- [Github Docs : Repos](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')