#### [GithubClient](index.md 'index')
### [GithubClient.Git](GithubClient.Git.md 'GithubClient.Git').[Blob](GithubClient.Git.Blob.md 'GithubClient.Git.Blob')

## Blob.GetEndpoint(string, string, string) Method

The endpoint used to get a blob from the API

```csharp
public static System.Uri GetEndpoint(string Owner, string Repo, string FileSha);
```
#### Parameters

<a name='GithubClient.Git.Blob.GetEndpoint(string,string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Git.Blob.GetEndpoint(string,string,string).Repo'></a>

`Repo` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

<a name='GithubClient.Git.Blob.GetEndpoint(string,string,string).FileSha'></a>

`FileSha` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Secure hashing algorithm

#### Returns
[System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

### Remarks
The content in the response will always be Base64 encoded.

### See Also
- [Get a Blob](https://docs.github.com/en/rest/git/blobs#get-a-blob 'https://docs.github.com/en/rest/git/blobs#get-a-blob')