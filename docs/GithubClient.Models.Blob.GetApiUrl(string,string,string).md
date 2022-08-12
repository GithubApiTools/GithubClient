#### [GithubClient](index 'index')
### [GithubClient.Models](GithubClient.Models 'GithubClient.Models').[Blob](GithubClient.Models.Blob 'GithubClient.Models.Blob')

## Blob.GetApiUrl(string, string, string) Method

```csharp
public static System.Uri GetApiUrl(string Owner, string Name, string Sha);
```
#### Parameters

<a name='GithubClient.Models.Blob.GetApiUrl(string,string,string).Owner'></a>

`Owner` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The account owner of the repository. This can also be the organization name. The name is not case sensitive.

<a name='GithubClient.Models.Blob.GetApiUrl(string,string,string).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the repository. The name is not case sensitive.

<a name='GithubClient.Models.Blob.GetApiUrl(string,string,string).Sha'></a>

`Sha` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Secure hashing algorithm

#### Returns
[System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')