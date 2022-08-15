#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Blobs](GithubClient.Methods.Blobs 'GithubClient.Methods.Blobs')

## Blobs.GetBlob(string, Tree) Method

Returns a blob object from the Github API

```csharp
public static System.Threading.Tasks.Task<GithubClient.Git.Blob>? GetBlob(string PAT, GithubClient.Git.Tree tree);
```
#### Parameters

<a name='GithubClient.Methods.Blobs.GetBlob(string,GithubClient.Git.Tree).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Blobs.GetBlob(string,GithubClient.Git.Tree).tree'></a>

`tree` [Tree](GithubClient.Git.Tree 'GithubClient.Git.Tree')

Object specifying a tree structure.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Blob](GithubClient.Git.Blob 'GithubClient.Git.Blob')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A blob object

### See Also
- [Github Docs : Blob](https://docs.github.com/en/rest/git/blobs 'https://docs.github.com/en/rest/git/blobs')