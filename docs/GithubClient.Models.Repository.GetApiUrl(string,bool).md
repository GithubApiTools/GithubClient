#### [GithubClient](index 'index')
### [GithubClient.Models](GithubClient.Models 'GithubClient.Models').[Repository](GithubClient.Models.Repository 'GithubClient.Models.Repository')

## Repository.GetApiUrl(string, bool) Method

```csharp
public static System.Uri GetApiUrl(string Owner, bool Org);
```
#### Parameters

<a name='GithubClient.Models.Repository.GetApiUrl(string,bool).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Models.Repository.GetApiUrl(string,bool).Org'></a>

`Org` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

True or False, is this an Organization

#### Returns
[System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')