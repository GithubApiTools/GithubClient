#### [GithubClient](index.md 'index')
### [GithubClient.Repositories](GithubClient.Repositories.md 'GithubClient.Repositories')

## ContentFile Class

The contents of a file or directory in a repository

```csharp
public class ContentFile : GithubClient.Repositories.GitObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [GitObject](GithubClient.Repositories.GitObject.md 'GithubClient.Repositories.GitObject') &#129106; ContentFile

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents 'https://docs.github.com/en/rest/repos/contents')

| Constructors | |
| :--- | :--- |
| [ContentFile(string, string)](GithubClient.Repositories.ContentFile.ContentFile(string,string).md 'GithubClient.Repositories.ContentFile.ContentFile(string, string)') | |

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Repositories.ContentFile.Api.md 'GithubClient.Repositories.ContentFile.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [Content](GithubClient.Repositories.ContentFile.Content.md 'GithubClient.Repositories.ContentFile.Content') | File content |
| [DownloadUrl](GithubClient.Repositories.ContentFile.DownloadUrl.md 'GithubClient.Repositories.ContentFile.DownloadUrl') | The raw file download URl |
| [Encoding](GithubClient.Repositories.ContentFile.Encoding.md 'GithubClient.Repositories.ContentFile.Encoding') | Is always Base-64 |
| [GitUrl](GithubClient.Repositories.ContentFile.GitUrl.md 'GithubClient.Repositories.ContentFile.GitUrl') | Github API Url for this objects blob |
| [HtmlUrl](GithubClient.Repositories.ContentFile.HtmlUrl.md 'GithubClient.Repositories.ContentFile.HtmlUrl') | A Url to view this object in a browser |
| [Links](GithubClient.Repositories.ContentFile.Links.md 'GithubClient.Repositories.ContentFile.Links') | Collection of links |
| [Name](GithubClient.Repositories.ContentFile.Name.md 'GithubClient.Repositories.ContentFile.Name') | Name of the object4 |
| [Path](GithubClient.Repositories.ContentFile.Path.md 'GithubClient.Repositories.ContentFile.Path') | Path to the object |
| [Sha](GithubClient.Repositories.ContentFile.Sha.md 'GithubClient.Repositories.ContentFile.Sha') | The file's SHA-1 hash |
| [Size](GithubClient.Repositories.ContentFile.Size.md 'GithubClient.Repositories.ContentFile.Size') | File size in bytes |
| [Type](GithubClient.Repositories.ContentFile.Type.md 'GithubClient.Repositories.ContentFile.Type') | file or dir |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Repositories.ContentFile.GetApiUrl().md 'GithubClient.Repositories.ContentFile.GetApiUrl()') | A method to return the API Url |
| [GetEndpointUrl(string, string, string)](GithubClient.Repositories.ContentFile.GetEndpointUrl(string,string,string).md 'GithubClient.Repositories.ContentFile.GetEndpointUrl(string, string, string)') | |
| [GetEndpointUrl(string, string, string, string)](GithubClient.Repositories.ContentFile.GetEndpointUrl(string,string,string,string).md 'GithubClient.Repositories.ContentFile.GetEndpointUrl(string, string, string, string)') | |
| [GetHeader()](GithubClient.Repositories.ContentFile.GetHeader().md 'GithubClient.Repositories.ContentFile.GetHeader()') | A method to return the default header |
| [PutEndpointUrl(string, string, string)](GithubClient.Repositories.ContentFile.PutEndpointUrl(string,string,string).md 'GithubClient.Repositories.ContentFile.PutEndpointUrl(string, string, string)') | |
