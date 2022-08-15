#### [GithubClient](index 'index')
### [GithubClient.Git](GithubClient.Git 'GithubClient.Git')

## BaseTree Class

A Git tree object creates the hierarchy between files in a Git repository

```csharp
public class BaseTree : GithubClient.Git.GitObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [GitObject](GithubClient.Git.GitObject 'GithubClient.Git.GitObject') &#129106; BaseTree

### See Also
- [Github Docs : Trees](https://docs.github.com/en/rest/git/trees 'https://docs.github.com/en/rest/git/trees')

| Constructors | |
| :--- | :--- |
| [BaseTree(List&lt;Tree&gt;)](GithubClient.Git.BaseTree.BaseTree(System.Collections.Generic.List_GithubClient.Git.Tree_) 'GithubClient.Git.BaseTree.BaseTree(System.Collections.Generic.List<GithubClient.Git.Tree>)') | Default ctor with required properties |

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Git.BaseTree.Api 'GithubClient.Git.BaseTree.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [Tree](GithubClient.Git.BaseTree.Tree 'GithubClient.Git.BaseTree.Tree') | A collection of Tree objects |
| [Truncated](GithubClient.Git.BaseTree.Truncated 'GithubClient.Git.BaseTree.Truncated') | |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Git.BaseTree.GetApiUrl() 'GithubClient.Git.BaseTree.GetApiUrl()') | A method to return the API Url |
| [GetEndpoint(string, string, string)](GithubClient.Git.BaseTree.GetEndpoint(string,string,string) 'GithubClient.Git.BaseTree.GetEndpoint(string, string, string)') | The endpoint used to get a tree from the API |
| [GetHeader()](GithubClient.Git.BaseTree.GetHeader() 'GithubClient.Git.BaseTree.GetHeader()') | A method to return the default header |
| [PostEndpoint(string, string)](GithubClient.Git.BaseTree.PostEndpoint(string,string) 'GithubClient.Git.BaseTree.PostEndpoint(string, string)') | The endpoint used to post a tree to the API |
