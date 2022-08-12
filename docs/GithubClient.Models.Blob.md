#### [GithubClient](index 'index')
### [GithubClient.Models](GithubClient.Models 'GithubClient.Models')

## Blob Class

A Git blob (binary large object) is the object type used to store the contents of each file in a repository.

```csharp
public class Blob
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Blob

### See Also
- [Github Docs : Blobs](https://docs.github.com/en/rest/git/blobs 'https://docs.github.com/en/rest/git/blobs')

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Models.Blob.Api 'GithubClient.Models.Blob.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [Content](GithubClient.Models.Blob.Content 'GithubClient.Models.Blob.Content') | File Contents |
| [Encoding](GithubClient.Models.Blob.Encoding 'GithubClient.Models.Blob.Encoding') | The encoding used for content. Currently, "utf-8" and "base64" are supported. |
| [NodeId](GithubClient.Models.Blob.NodeId 'GithubClient.Models.Blob.NodeId') | Id of a Node (Node is a generic term for an object) used in GraphQL |
| [Sha](GithubClient.Models.Blob.Sha 'GithubClient.Models.Blob.Sha') | The file's SHA-1 hash is computed and stored in the blob object |
| [Size](GithubClient.Models.Blob.Size 'GithubClient.Models.Blob.Size') | File size in bytes |
| [Url](GithubClient.Models.Blob.Url 'GithubClient.Models.Blob.Url') | Github API Url for this object |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Models.Blob.GetApiUrl() 'GithubClient.Models.Blob.GetApiUrl()') | A method to return the API Url |
| [GetApiUrl(string, string, string)](GithubClient.Models.Blob.GetApiUrl(string,string,string) 'GithubClient.Models.Blob.GetApiUrl(string, string, string)') | |
| [GetHeader()](GithubClient.Models.Blob.GetHeader() 'GithubClient.Models.Blob.GetHeader()') | A method to return the default header |
