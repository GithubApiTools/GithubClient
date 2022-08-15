#### [GithubClient](index.md 'index')
### [GithubClient.Repositories](GithubClient.Repositories.md 'GithubClient.Repositories').[Repository](GithubClient.Repositories.Repository.md 'GithubClient.Repositories.Repository')

## Repository.GetEndpoint(string, string) Method

```csharp
public static System.Uri GetEndpoint(string Owner, string Repo);
```
#### Parameters

<a name='GithubClient.Repositories.Repository.GetEndpoint(string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Repositories.Repository.GetEndpoint(string,string).Repo'></a>

`Repo` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

#### Returns
[System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')