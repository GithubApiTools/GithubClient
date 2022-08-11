#### [GithubClient](index.md 'index')
### [GithubClient.Blobs](GithubClient.Blobs.md 'GithubClient.Blobs').[Methods](GithubClient.Blobs.Methods.md 'GithubClient.Blobs.Methods')

## Methods.GetBlob(string, string, Tree) Method

Returns a blob object from the Github API

```csharp
public static System.Threading.Tasks.Task<GithubClient.Models.Blob> GetBlob(string PAT, string GithubUrl, GithubClient.Models.Tree tree);
```
#### Parameters

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,GithubClient.Models.Tree).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,GithubClient.Models.Tree).GithubUrl'></a>

`GithubUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Github API Url

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,GithubClient.Models.Tree).tree'></a>

`tree` [GithubClient.Models.Tree](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.Tree 'GithubClient.Models.Tree')

Object specifying a tree structure.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[GithubClient.Models.Blob](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.Blob 'GithubClient.Models.Blob')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A blob object

### See Also
- [Github Docs : Blob](https://docs.github.com/en/rest/git/blobs 'https://docs.github.com/en/rest/git/blobs')