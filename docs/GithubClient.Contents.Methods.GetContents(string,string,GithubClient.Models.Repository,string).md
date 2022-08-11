#### [GithubClient](index.md 'index')
### [GithubClient.Contents](GithubClient.Contents.md 'GithubClient.Contents').[Methods](GithubClient.Contents.Methods.md 'GithubClient.Contents.Methods')

## Methods.GetContents(string, string, Repository, string) Method

Returns a content object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<GithubClient.Models.DirectoryContent>> GetContents(string PAT, string GithubUrl, GithubClient.Models.Repository repository, string Ref="main");
```
#### Parameters

<a name='GithubClient.Contents.Methods.GetContents(string,string,GithubClient.Models.Repository,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Contents.Methods.GetContents(string,string,GithubClient.Models.Repository,string).GithubUrl'></a>

`GithubUrl` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Github API Url

<a name='GithubClient.Contents.Methods.GetContents(string,string,GithubClient.Models.Repository,string).repository'></a>

`repository` [GithubClient.Models.Repository](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.Repository 'GithubClient.Models.Repository')

A Repository object

<a name='GithubClient.Contents.Methods.GetContents(string,string,GithubClient.Models.Repository,string).Ref'></a>

`Ref` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the commit/branch/tag. Default: the repository’s default branch (usually master)

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[GithubClient.Models.DirectoryContent](https://docs.microsoft.com/en-us/dotnet/api/GithubClient.Models.DirectoryContent 'GithubClient.Models.DirectoryContent')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A DirectoryContent object

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents#get-repository-content 'https://docs.github.com/en/rest/repos/contents#get-repository-content')