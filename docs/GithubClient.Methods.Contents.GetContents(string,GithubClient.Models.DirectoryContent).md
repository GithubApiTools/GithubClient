#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Contents](GithubClient.Methods.Contents 'GithubClient.Methods.Contents')

## Contents.GetContents(string, DirectoryContent) Method

Returns a content object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<GithubClient.Models.DirectoryContent>>? GetContents(string PAT, GithubClient.Models.DirectoryContent content);
```
#### Parameters

<a name='GithubClient.Methods.Contents.GetContents(string,GithubClient.Models.DirectoryContent).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Contents.GetContents(string,GithubClient.Models.DirectoryContent).content'></a>

`content` [DirectoryContent](GithubClient.Models.DirectoryContent 'GithubClient.Models.DirectoryContent')

A DirectoryContent object

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[DirectoryContent](GithubClient.Models.DirectoryContent 'GithubClient.Models.DirectoryContent')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A DirectoryContent object

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents#get-repository-content 'https://docs.github.com/en/rest/repos/contents#get-repository-content')