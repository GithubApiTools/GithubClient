#### [GithubClient](index 'index')
### [GithubClient.Blobs](GithubClient.Blobs 'GithubClient.Blobs').[Methods](GithubClient.Blobs.Methods 'GithubClient.Blobs.Methods')

## Methods.GetBlob(string, string, DirectoryContent) Method

Returns a blob object from the Github API

```csharp
public static System.Threading.Tasks.Task<GithubClient.Models.Blob> GetBlob(string PAT, string GithubUrl, GithubClient.Models.DirectoryContent content);
```
#### Parameters

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,GithubClient.Models.DirectoryContent).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,GithubClient.Models.DirectoryContent).GithubUrl'></a>

`GithubUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Github API Url

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,GithubClient.Models.DirectoryContent).content'></a>

`content` [GithubClient.Models.DirectoryContent](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.DirectoryContent 'GithubClient.Models.DirectoryContent')

The contents of a file or directory in a repository.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[GithubClient.Models.Blob](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.Blob 'GithubClient.Models.Blob')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A blob object

### See Also
- [Github Docs : Blob](https://docs.github.com/en/rest/git/blobs 'https://docs.github.com/en/rest/git/blobs')