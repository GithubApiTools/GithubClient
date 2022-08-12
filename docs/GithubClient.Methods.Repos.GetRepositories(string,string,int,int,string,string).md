#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Repos](GithubClient.Methods.Repos 'GithubClient.Methods.Repos')

## Repos.GetRepositories(string, string, int, int, string, string) Method

Returns a repository object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<GithubClient.Models.Repository>> GetRepositories(string PAT, string Owner, int PerPage=30, int Page=1, string Type="all", string Direction="asc");
```
#### Parameters

<a name='GithubClient.Methods.Repos.GetRepositories(string,string,int,int,string,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Repos.GetRepositories(string,string,int,int,string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Methods.Repos.GetRepositories(string,string,int,int,string,string).PerPage'></a>

`PerPage` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of results per page (max 100).

<a name='GithubClient.Methods.Repos.GetRepositories(string,string,int,int,string,string).Page'></a>

`Page` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Page number of the results to fetch

<a name='GithubClient.Methods.Repos.GetRepositories(string,string,int,int,string,string).Type'></a>

`Type` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Specifies the types of repositories you want returned.

<a name='GithubClient.Methods.Repos.GetRepositories(string,string,int,int,string,string).Direction'></a>

`Direction` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The order to sort by. Default: asc

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Repository](GithubClient.Models.Repository 'GithubClient.Models.Repository')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A collection of repository objects

### See Also
- [Github Docs : Repos](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')