#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Contents](GithubClient.Methods.Contents 'GithubClient.Methods.Contents')

## Contents.GetFile(string, ContentDirectory) Method

Returns a content object from the Github API

```csharp
public static System.Threading.Tasks.Task<object> GetFile(string PAT, GithubClient.Repositories.ContentDirectory content);
```
#### Parameters

<a name='GithubClient.Methods.Contents.GetFile(string,GithubClient.Repositories.ContentDirectory).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Contents.GetFile(string,GithubClient.Repositories.ContentDirectory).content'></a>

`content` [ContentDirectory](GithubClient.Repositories.ContentDirectory 'GithubClient.Repositories.ContentDirectory')

A DirectoryContent object

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A FileContent object

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents#get-repository-content 'https://docs.github.com/en/rest/repos/contents#get-repository-content')