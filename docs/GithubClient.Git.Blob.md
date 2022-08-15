#### [GithubClient](index 'index')
### [GithubClient.Git](GithubClient.Git 'GithubClient.Git')

## Blob Class

A Git blob (binary large object) is the object type used to store the contents of each file in a repository.

```csharp
public class Blob : GithubClient.Git.GitObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [GitObject](GithubClient.Git.GitObject 'GithubClient.Git.GitObject') &#129106; Blob

### See Also
- [Github Docs : Blobs](https://docs.github.com/en/rest/git/blobs 'https://docs.github.com/en/rest/git/blobs')

| Constructors | |
| :--- | :--- |
| [Blob(string, string)](GithubClient.Git.Blob.Blob(string,string) 'GithubClient.Git.Blob.Blob(string, string)') | Default ctor with required properties |

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Git.Blob.Api 'GithubClient.Git.Blob.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [Content](GithubClient.Git.Blob.Content 'GithubClient.Git.Blob.Content') | File Contents |
| [Encoding](GithubClient.Git.Blob.Encoding 'GithubClient.Git.Blob.Encoding') | The encoding used for content. Currently, "utf-8" and "base64" are supported. |
| [HighlightedContent](GithubClient.Git.Blob.HighlightedContent 'GithubClient.Git.Blob.HighlightedContent') | |
| [NodeId](GithubClient.Git.Blob.NodeId 'GithubClient.Git.Blob.NodeId') | Id of a Node (Node is a generic term for an object) used in GraphQL |
| [Size](GithubClient.Git.Blob.Size 'GithubClient.Git.Blob.Size') | File size in bytes |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Git.Blob.GetApiUrl() 'GithubClient.Git.Blob.GetApiUrl()') | A method to return the API Url |
| [GetEndpoint(string, string, string)](GithubClient.Git.Blob.GetEndpoint(string,string,string) 'GithubClient.Git.Blob.GetEndpoint(string, string, string)') | The endpoint used to get a blob from the API |
| [GetHeader()](GithubClient.Git.Blob.GetHeader() 'GithubClient.Git.Blob.GetHeader()') | A method to return the default header |
| [PostEndpoint(string, string)](GithubClient.Git.Blob.PostEndpoint(string,string) 'GithubClient.Git.Blob.PostEndpoint(string, string)') | The endpoint used to post a blob to the API |
