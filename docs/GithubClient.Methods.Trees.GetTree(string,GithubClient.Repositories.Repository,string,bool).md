#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Trees](GithubClient.Methods.Trees 'GithubClient.Methods.Trees')

## Trees.GetTree(string, Repository, string, bool) Method

Returns a repository Tree from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<GithubClient.Git.BaseTree>>? GetTree(string PAT, GithubClient.Repositories.Repository repository, string Ref="main", bool Recursive=true);
```
#### Parameters

<a name='GithubClient.Methods.Trees.GetTree(string,GithubClient.Repositories.Repository,string,bool).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Trees.GetTree(string,GithubClient.Repositories.Repository,string,bool).repository'></a>

`repository` [Repository](GithubClient.Repositories.Repository 'GithubClient.Repositories.Repository')

A Repository object

<a name='GithubClient.Methods.Trees.GetTree(string,GithubClient.Repositories.Repository,string,bool).Ref'></a>

`Ref` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the commit/branch/tag. Default: the repository’s default branch (usually master)

<a name='GithubClient.Methods.Trees.GetTree(string,GithubClient.Repositories.Repository,string,bool).Recursive'></a>

`Recursive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Setting this parameter to any value returns the objects or subtrees referenced by the tree specified in :tree_sha

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[BaseTree](GithubClient.Git.BaseTree 'GithubClient.Git.BaseTree')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A tree object

### See Also
- [Github Docs : Trees](https://docs.github.com/en/rest/git/trees 'https://docs.github.com/en/rest/git/trees')