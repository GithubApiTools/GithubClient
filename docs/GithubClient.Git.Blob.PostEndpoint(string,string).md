#### [GithubClient](index.md 'index')
### [GithubClient.Git](GithubClient.Git.md 'GithubClient.Git').[Blob](GithubClient.Git.Blob.md 'GithubClient.Git.Blob')

## Blob.PostEndpoint(string, string) Method

The endpoint used to post a blob to the API

```csharp
public static System.Uri PostEndpoint(string Owner, string Repo);
```
#### Parameters

<a name='GithubClient.Git.Blob.PostEndpoint(string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Git.Blob.PostEndpoint(string,string).Repo'></a>

`Repo` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

#### Returns
[System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

### See Also
- [Create a Blob](https://docs.github.com/en/rest/git/blobs#create-a-blob 'https://docs.github.com/en/rest/git/blobs#create-a-blob')