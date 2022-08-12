#### [GithubClient](index 'index')
### [GithubClient.Models](GithubClient.Models 'GithubClient.Models')

## FileContent Class

The contents of a file or directory in a repository

```csharp
public class FileContent
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FileContent

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents 'https://docs.github.com/en/rest/repos/contents')

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Models.FileContent.Api 'GithubClient.Models.FileContent.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [Content](GithubClient.Models.FileContent.Content 'GithubClient.Models.FileContent.Content') | File content |
| [DownloadUrl](GithubClient.Models.FileContent.DownloadUrl 'GithubClient.Models.FileContent.DownloadUrl') | The raw file download URl |
| [Encoding](GithubClient.Models.FileContent.Encoding 'GithubClient.Models.FileContent.Encoding') | Is always Base-64 |
| [GitUrl](GithubClient.Models.FileContent.GitUrl 'GithubClient.Models.FileContent.GitUrl') | Github API Url for this objects blob |
| [HtmlUrl](GithubClient.Models.FileContent.HtmlUrl 'GithubClient.Models.FileContent.HtmlUrl') | A Url to view this object in a browser |
| [Links](GithubClient.Models.FileContent.Links 'GithubClient.Models.FileContent.Links') | Collection of links |
| [Name](GithubClient.Models.FileContent.Name 'GithubClient.Models.FileContent.Name') | Name of the object4 |
| [Path](GithubClient.Models.FileContent.Path 'GithubClient.Models.FileContent.Path') | Path to the object |
| [Sha](GithubClient.Models.FileContent.Sha 'GithubClient.Models.FileContent.Sha') | The file's SHA-1 hash |
| [Size](GithubClient.Models.FileContent.Size 'GithubClient.Models.FileContent.Size') | File size in bytes |
| [Type](GithubClient.Models.FileContent.Type 'GithubClient.Models.FileContent.Type') | file or dir |
| [Url](GithubClient.Models.FileContent.Url 'GithubClient.Models.FileContent.Url') | Github API Url for this object |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Models.FileContent.GetApiUrl() 'GithubClient.Models.FileContent.GetApiUrl()') | A method to return the API Url |
| [GetHeader()](GithubClient.Models.FileContent.GetHeader() 'GithubClient.Models.FileContent.GetHeader()') | A method to return the default header |
