#### [GithubClient](index.md 'index')
### [GithubClient.Git](GithubClient.Git.md 'GithubClient.Git')

## Tree Class

A Git tree object creates the hierarchy between files in a Git repository

```csharp
public class Tree : GithubClient.Git.GitObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [GitObject](GithubClient.Git.GitObject.md 'GithubClient.Git.GitObject') &#129106; Tree

### See Also
- [Github Docs : Trees](https://docs.github.com/en/rest/git/trees 'https://docs.github.com/en/rest/git/trees')

| Properties | |
| :--- | :--- |
| [Mode](GithubClient.Git.Tree.Mode.md 'GithubClient.Git.Tree.Mode') | The file mode; one of 100644 for file (blob), 100755 for executable (blob), 040000 for subdirectory (tree), 160000 for submodule (commit), or 120000 for a blob that specifies the path of a symlink. |
| [Path](GithubClient.Git.Tree.Path.md 'GithubClient.Git.Tree.Path') | Path to the object |
| [Size](GithubClient.Git.Tree.Size.md 'GithubClient.Git.Tree.Size') | File size in bytes |
| [Type](GithubClient.Git.Tree.Type.md 'GithubClient.Git.Tree.Type') | Either blob, tree, or commit |
