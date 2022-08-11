#### [GithubClient](index 'index')
### [GithubClient.Blobs](GithubClient.Blobs 'GithubClient.Blobs').[Methods](GithubClient.Blobs.Methods 'GithubClient.Blobs.Methods')

## Methods.GetBlob(string, string, string, string, string) Method

Returns a blob object from the Github API

```csharp
public static System.Threading.Tasks.Task<GithubClient.Models.Blob> GetBlob(string PAT, string GithubUrl, string Owner, string Name, string Sha);
```
#### Parameters

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,string,string,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,string,string,string).GithubUrl'></a>

`GithubUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Github API Url

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,string,string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,string,string,string).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

<a name='GithubClient.Blobs.Methods.GetBlob(string,string,string,string,string).Sha'></a>

`Sha` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Secure hashing algorithm

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[GithubClient.Models.Blob](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.Blob 'GithubClient.Models.Blob')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A blob object

### See Also
- [Github Docs : Blob](https://docs.github.com/en/rest/git/blobs 'https://docs.github.com/en/rest/git/blobs')