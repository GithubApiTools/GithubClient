#### [GithubClient](index 'index')
### [GithubClient.Methods](GithubClient.Methods 'GithubClient.Methods').[Contents](GithubClient.Methods.Contents 'GithubClient.Methods.Contents')

## Contents.GetContents(string, Repository, string) Method

Returns a content object from the Github API

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<GithubClient.Repositories.ContentDirectory>>? GetContents(string PAT, GithubClient.Repositories.Repository repository, string Ref="main");
```
#### Parameters

<a name='GithubClient.Methods.Contents.GetContents(string,GithubClient.Repositories.Repository,string).PAT'></a>

`PAT` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Personal Access Token

<a name='GithubClient.Methods.Contents.GetContents(string,GithubClient.Repositories.Repository,string).repository'></a>

`repository` [Repository](GithubClient.Repositories.Repository 'GithubClient.Repositories.Repository')

A Repository object

<a name='GithubClient.Methods.Contents.GetContents(string,GithubClient.Repositories.Repository,string).Ref'></a>

`Ref` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the commit/branch/tag. Default: the repository’s default branch (usually master)

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[ContentDirectory](GithubClient.Repositories.ContentDirectory 'GithubClient.Repositories.ContentDirectory')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
A DirectoryContent object

### See Also
- [Github Docs : Contents](https://docs.github.com/en/rest/repos/contents#get-repository-content 'https://docs.github.com/en/rest/repos/contents#get-repository-content')