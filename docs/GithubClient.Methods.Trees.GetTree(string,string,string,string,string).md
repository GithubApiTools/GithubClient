#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Trees](GithubClient.Methods.Trees 'GithubClient.Methods.Trees')

## Trees.GetTree(string, string, string, string, string) Method

Returns a repository Tree from the Github API

```csharp
public static System.Threading.Tasks.Task<GithubClient.Models.BaseTree> GetTree(string PAT, string GithubUrl, string Owner, string Name, string Ref="main");
```
#### Parameters

<a name='GithubClient.Methods.Trees.GetTree(string,string,string,string,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Trees.GetTree(string,string,string,string,string).GithubUrl'></a>

`GithubUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Github API Url

<a name='GithubClient.Methods.Trees.GetTree(string,string,string,string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Methods.Trees.GetTree(string,string,string,string,string).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

<a name='GithubClient.Methods.Trees.GetTree(string,string,string,string,string).Ref'></a>

`Ref` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the commit/branch/tag. Default: the repository’s default branch (usually master)

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[BaseTree](GithubClient.Models.BaseTree 'GithubClient.Models.BaseTree')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A tree object

### See Also
- [Github Docs : Trees](https://docs.github.com/en/rest/git/trees 'https://docs.github.com/en/rest/git/trees')