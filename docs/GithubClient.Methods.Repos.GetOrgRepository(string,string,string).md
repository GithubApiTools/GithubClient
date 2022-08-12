#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Repos](GithubClient.Methods.Repos 'GithubClient.Methods.Repos')

## Repos.GetOrgRepository(string, string, string) Method

Returns a repository object from the Github API

```csharp
public static System.Threading.Tasks.Task<GithubClient.Models.Repository> GetOrgRepository(string PAT, string Org, string Name);
```
#### Parameters

<a name='GithubClient.Methods.Repos.GetOrgRepository(string,string,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Repos.GetOrgRepository(string,string,string).Org'></a>

`Org` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Methods.Repos.GetOrgRepository(string,string,string).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Repository](GithubClient.Models.Repository 'GithubClient.Models.Repository')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A repository object

### See Also
- [Github Docs : Repos](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')