#### [GithubClient](index.md 'index')
### [GithubClient.Methods](GithubClient.Methods.md 'GithubClient.Methods').[Contents](GithubClient.Methods.Contents.md 'GithubClient.Methods.Contents')

## Contents.GetContents(string, ContentDirectory) Method

Returns a content object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<GithubClient.Repositories.ContentDirectory>>? GetContents(string PAT, GithubClient.Repositories.ContentDirectory content);
```
#### Parameters

<a name='GithubClient.Methods.Contents.GetContents(string,GithubClient.Repositories.ContentDirectory).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Contents.GetContents(string,GithubClient.Repositories.ContentDirectory).content'></a>

`content` [ContentDirectory](GithubClient.Repositories.ContentDirectory.md 'GithubClient.Repositories.ContentDirectory')

A DirectoryContent object

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ContentDirectory](GithubClient.Repositories.ContentDirectory.md 'GithubClient.Repositories.ContentDirectory')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A DirectoryContent object

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents#get-repository-content 'https://docs.github.com/en/rest/repos/contents#get-repository-content')