#### [GithubClient](index 'index')
### [GithubClient.Repositories](GithubClient.Repositories 'GithubClient.Repositories').[Methods](GithubClient.Repositories.Methods 'GithubClient.Repositories.Methods')

## Methods.GetRepositories(string, string, string, int, int) Method

Returns a repository object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<GithubClient.Models.Repository>> GetRepositories(string PAT, string GithubUrl, string Owner, int PerPage=30, int Page=1);
```
#### Parameters

<a name='GithubClient.Repositories.Methods.GetRepositories(string,string,string,int,int).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Repositories.Methods.GetRepositories(string,string,string,int,int).GithubUrl'></a>

`GithubUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Github API Url

<a name='GithubClient.Repositories.Methods.GetRepositories(string,string,string,int,int).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Repositories.Methods.GetRepositories(string,string,string,int,int).PerPage'></a>

`PerPage` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of results per page (max 100).

<a name='GithubClient.Repositories.Methods.GetRepositories(string,string,string,int,int).Page'></a>

`Page` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Page number of the results to fetch

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[GithubClient.Models.Repository](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.Repository 'GithubClient.Models.Repository')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A collection of repository objects

### See Also
- [Github Docs : Repos](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')