#### [GithubClient](index.md 'index')
### [GithubClient.Methods](GithubClient.Methods.md 'GithubClient.Methods').[Repos](GithubClient.Methods.Repos.md 'GithubClient.Methods.Repos')

## Repos.GetRepository(string, string, string) Method

Returns a repository object from the Github API

```csharp
public static System.Threading.Tasks.Task<GithubClient.Repositories.Repository> GetRepository(string PAT, string Owner, string Name);
```
#### Parameters

<a name='GithubClient.Methods.Repos.GetRepository(string,string,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Repos.GetRepository(string,string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Methods.Repos.GetRepository(string,string,string).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Repository](GithubClient.Repositories.Repository.md 'GithubClient.Repositories.Repository')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A repository object

### See Also
- [Github Docs : Repos](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')