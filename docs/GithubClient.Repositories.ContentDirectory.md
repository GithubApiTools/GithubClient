#### [GithubClient](index 'index')
### [GithubClient.Repositories](GithubClient.Repositories 'GithubClient.Repositories')

## ContentDirectory Class

The contents of a file or directory in a repository

```csharp
public class ContentDirectory : GithubClient.Repositories.GitObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [GitObject](GithubClient.Repositories.GitObject 'GithubClient.Repositories.GitObject') &#129106; ContentDirectory

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents 'https://docs.github.com/en/rest/repos/contents')

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Repositories.ContentDirectory.Api 'GithubClient.Repositories.ContentDirectory.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [DownloadUrl](GithubClient.Repositories.ContentDirectory.DownloadUrl 'GithubClient.Repositories.ContentDirectory.DownloadUrl') | The raw file download URl |
| [GitUrl](GithubClient.Repositories.ContentDirectory.GitUrl 'GithubClient.Repositories.ContentDirectory.GitUrl') | Github API Url for this objects blob |
| [HtmlUrl](GithubClient.Repositories.ContentDirectory.HtmlUrl 'GithubClient.Repositories.ContentDirectory.HtmlUrl') | A Url to view this object in a browser |
| [Links](GithubClient.Repositories.ContentDirectory.Links 'GithubClient.Repositories.ContentDirectory.Links') | Collection of links |
| [Name](GithubClient.Repositories.ContentDirectory.Name 'GithubClient.Repositories.ContentDirectory.Name') | Name of the object |
| [Path](GithubClient.Repositories.ContentDirectory.Path 'GithubClient.Repositories.ContentDirectory.Path') | Path to the object |
| [Sha](GithubClient.Repositories.ContentDirectory.Sha 'GithubClient.Repositories.ContentDirectory.Sha') | The file's SHA-1 hash |
| [Size](GithubClient.Repositories.ContentDirectory.Size 'GithubClient.Repositories.ContentDirectory.Size') | File size in bytes |
| [Type](GithubClient.Repositories.ContentDirectory.Type 'GithubClient.Repositories.ContentDirectory.Type') | file or dir |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Repositories.ContentDirectory.GetApiUrl() 'GithubClient.Repositories.ContentDirectory.GetApiUrl()') | A method to return the API Url |
| [GetEndpointUrl(string, string)](GithubClient.Repositories.ContentDirectory.GetEndpointUrl(string,string) 'GithubClient.Repositories.ContentDirectory.GetEndpointUrl(string, string)') | |
| [GetEndpointUrl(string, string, string)](GithubClient.Repositories.ContentDirectory.GetEndpointUrl(string,string,string) 'GithubClient.Repositories.ContentDirectory.GetEndpointUrl(string, string, string)') | |
| [GetEndpointUrl(string, string, string, string)](GithubClient.Repositories.ContentDirectory.GetEndpointUrl(string,string,string,string) 'GithubClient.Repositories.ContentDirectory.GetEndpointUrl(string, string, string, string)') | |
| [GetHeader()](GithubClient.Repositories.ContentDirectory.GetHeader() 'GithubClient.Repositories.ContentDirectory.GetHeader()') | A method to return the default header |
