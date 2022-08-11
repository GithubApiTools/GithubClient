#### [GithubClient](index 'index')
### [GithubClient.Models](GithubClient.Models 'GithubClient.Models')

## Tree Class

A Git tree object creates the hierarchy between files in a Git repository

```csharp
public class Tree
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Tree

### See Also
- [Github Docs : Trees](https://docs.github.com/en/rest/git/trees 'https://docs.github.com/en/rest/git/trees')

| Properties | |
| :--- | :--- |
| [Mode](GithubClient.Models.Tree.Mode 'GithubClient.Models.Tree.Mode') | The file mode; one of 100644 for file (blob), 100755 for executable (blob), 040000 for subdirectory (tree), 160000 for submodule (commit), or 120000 for a blob that specifies the path of a symlink. |
| [Path](GithubClient.Models.Tree.Path 'GithubClient.Models.Tree.Path') | Path to the object |
| [Sha](GithubClient.Models.Tree.Sha 'GithubClient.Models.Tree.Sha') | The object's SHA-1 hash |
| [Size](GithubClient.Models.Tree.Size 'GithubClient.Models.Tree.Size') | File size in bytes |
| [Type](GithubClient.Models.Tree.Type 'GithubClient.Models.Tree.Type') | Either blob, tree, or commit |
| [Url](GithubClient.Models.Tree.Url 'GithubClient.Models.Tree.Url') | Github API Url for this object |

| Methods | |
| :--- | :--- |
| [GetHeader()](GithubClient.Models.Tree.GetHeader() 'GithubClient.Models.Tree.GetHeader()') | A method to return the default header |
