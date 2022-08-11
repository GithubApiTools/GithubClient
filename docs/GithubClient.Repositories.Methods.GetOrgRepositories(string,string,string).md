#### [GithubClient](index 'index')
### [GithubClient.Repositories](GithubClient.Repositories 'GithubClient.Repositories').[Methods](GithubClient.Repositories.Methods 'GithubClient.Repositories.Methods')

## Methods.GetOrgRepositories(string, string, string) Method

Returns a repository object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<GithubClient.Models.Repository>> GetOrgRepositories(string PAT, string GithubUrl, string Org);
```
#### Parameters

<a name='GithubClient.Repositories.Methods.GetOrgRepositories(string,string,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Repositories.Methods.GetOrgRepositories(string,string,string).GithubUrl'></a>

`GithubUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Github API Url

<a name='GithubClient.Repositories.Methods.GetOrgRepositories(string,string,string).Org'></a>

`Org` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Repository](GithubClient.Models.Repository 'GithubClient.Models.Repository')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A collection of repository objects

### See Also
- [Github Docs : Repos](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')