#### [GithubClient](index 'index')
### [GithubClient.Repositories](GithubClient.Repositories 'GithubClient.Repositories')

## Repository Class

The ultimate source for the network

```csharp
public class Repository : GithubClient.Repositories.GitObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [GitObject](GithubClient.Repositories.GitObject 'GithubClient.Repositories.GitObject') &#129106; Repository

### See Also
- [Github Docs : Repositories](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')

| Constructors | |
| :--- | :--- |
| [Repository(string)](GithubClient.Repositories.Repository.Repository(string) 'GithubClient.Repositories.Repository.Repository(string)') | Default ctor with required properties |

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Repositories.Repository.Api 'GithubClient.Repositories.Repository.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [AllowForking](GithubClient.Repositories.Repository.AllowForking 'GithubClient.Repositories.Repository.AllowForking') | Either true to allow private forks, or false to prevent private forks |
| [Archived](GithubClient.Repositories.Repository.Archived 'GithubClient.Repositories.Repository.Archived') | true to archive this repository. Note: You cannot unarchive repositories through the API |
| [ArchiveUrl](GithubClient.Repositories.Repository.ArchiveUrl 'GithubClient.Repositories.Repository.ArchiveUrl') | Github API Endpoint Url |
| [AssigneesUrl](GithubClient.Repositories.Repository.AssigneesUrl 'GithubClient.Repositories.Repository.AssigneesUrl') | Github API Endpoint Url |
| [BlobsUrl](GithubClient.Repositories.Repository.BlobsUrl 'GithubClient.Repositories.Repository.BlobsUrl') | Github API Endpoint Url |
| [BranchesUrl](GithubClient.Repositories.Repository.BranchesUrl 'GithubClient.Repositories.Repository.BranchesUrl') | Github API Endpoint Url |
| [CloneUrl](GithubClient.Repositories.Repository.CloneUrl 'GithubClient.Repositories.Repository.CloneUrl') | Http Clone Url |
| [CollaboratorsUrl](GithubClient.Repositories.Repository.CollaboratorsUrl 'GithubClient.Repositories.Repository.CollaboratorsUrl') | Github API Endpoint Url |
| [CommentsUrl](GithubClient.Repositories.Repository.CommentsUrl 'GithubClient.Repositories.Repository.CommentsUrl') | Github API Endpoint Url |
| [CommitsUrl](GithubClient.Repositories.Repository.CommitsUrl 'GithubClient.Repositories.Repository.CommitsUrl') | Github API Endpoint Url |
| [CompareUrl](GithubClient.Repositories.Repository.CompareUrl 'GithubClient.Repositories.Repository.CompareUrl') | Github API Endpoint Url |
| [ContentsUrl](GithubClient.Repositories.Repository.ContentsUrl 'GithubClient.Repositories.Repository.ContentsUrl') | Github API Endpoint Url |
| [ContributorsUrl](GithubClient.Repositories.Repository.ContributorsUrl 'GithubClient.Repositories.Repository.ContributorsUrl') | Github API Endpoint Url |
| [CreatedAt](GithubClient.Repositories.Repository.CreatedAt 'GithubClient.Repositories.Repository.CreatedAt') | Repository Creation Date |
| [DefaultBranch](GithubClient.Repositories.Repository.DefaultBranch 'GithubClient.Repositories.Repository.DefaultBranch') | Default repository branch |
| [DeploymentsUrl](GithubClient.Repositories.Repository.DeploymentsUrl 'GithubClient.Repositories.Repository.DeploymentsUrl') | Github API Endpoint Url |
| [Description](GithubClient.Repositories.Repository.Description 'GithubClient.Repositories.Repository.Description') | A short description of the repository |
| [Disabled](GithubClient.Repositories.Repository.Disabled 'GithubClient.Repositories.Repository.Disabled') | True or False |
| [DownloadsUrl](GithubClient.Repositories.Repository.DownloadsUrl 'GithubClient.Repositories.Repository.DownloadsUrl') | Github API Endpoint Url |
| [EventsUrl](GithubClient.Repositories.Repository.EventsUrl 'GithubClient.Repositories.Repository.EventsUrl') | Github API Endpoint Url |
| [Fork](GithubClient.Repositories.Repository.Fork 'GithubClient.Repositories.Repository.Fork') | True if this repository is forked |
| [Forks](GithubClient.Repositories.Repository.Forks 'GithubClient.Repositories.Repository.Forks') | Number of forks |
| [ForksCount](GithubClient.Repositories.Repository.ForksCount 'GithubClient.Repositories.Repository.ForksCount') | Count of Forks |
| [ForksUrl](GithubClient.Repositories.Repository.ForksUrl 'GithubClient.Repositories.Repository.ForksUrl') | Github API Endpoint Url |
| [FullName](GithubClient.Repositories.Repository.FullName 'GithubClient.Repositories.Repository.FullName') | A short description of the repository |
| [GitCommitsUrl](GithubClient.Repositories.Repository.GitCommitsUrl 'GithubClient.Repositories.Repository.GitCommitsUrl') | Github API Endpoint Url |
| [GitRefsUrl](GithubClient.Repositories.Repository.GitRefsUrl 'GithubClient.Repositories.Repository.GitRefsUrl') | Github API Endpoint Url |
| [GitTagsUrl](GithubClient.Repositories.Repository.GitTagsUrl 'GithubClient.Repositories.Repository.GitTagsUrl') | Github API Endpoint Url |
| [GitUrl](GithubClient.Repositories.Repository.GitUrl 'GithubClient.Repositories.Repository.GitUrl') | Git Clone Url |
| [HasDownloads](GithubClient.Repositories.Repository.HasDownloads 'GithubClient.Repositories.Repository.HasDownloads') | True or False if downloads are available |
| [HasIssues](GithubClient.Repositories.Repository.HasIssues 'GithubClient.Repositories.Repository.HasIssues') | Either true to enable issues for this repository or false to disable them |
| [HasPages](GithubClient.Repositories.Repository.HasPages 'GithubClient.Repositories.Repository.HasPages') | Either true to enable the pages for this repository or false to disable it. |
| [HasProjects](GithubClient.Repositories.Repository.HasProjects 'GithubClient.Repositories.Repository.HasProjects') | Either true to enable projects for this repository or false to disable them |
| [HasWiki](GithubClient.Repositories.Repository.HasWiki 'GithubClient.Repositories.Repository.HasWiki') | Either true to enable the wiki for this repository or false to disable it. |
| [Homepage](GithubClient.Repositories.Repository.Homepage 'GithubClient.Repositories.Repository.Homepage') | A URL with more information about the repository |
| [HooksUrl](GithubClient.Repositories.Repository.HooksUrl 'GithubClient.Repositories.Repository.HooksUrl') | Github API Endpoint Url |
| [HtmlUrl](GithubClient.Repositories.Repository.HtmlUrl 'GithubClient.Repositories.Repository.HtmlUrl') | A Url to view this object in a browser |
| [Id](GithubClient.Repositories.Repository.Id 'GithubClient.Repositories.Repository.Id') | Github Id |
| [IssueCommentUrl](GithubClient.Repositories.Repository.IssueCommentUrl 'GithubClient.Repositories.Repository.IssueCommentUrl') | Github API Endpoint Url |
| [IssueEventsUrl](GithubClient.Repositories.Repository.IssueEventsUrl 'GithubClient.Repositories.Repository.IssueEventsUrl') | Github API Endpoint Url |
| [IssuesUrl](GithubClient.Repositories.Repository.IssuesUrl 'GithubClient.Repositories.Repository.IssuesUrl') | Github API Endpoint Url |
| [IsTemplate](GithubClient.Repositories.Repository.IsTemplate 'GithubClient.Repositories.Repository.IsTemplate') | Either true to make this repo available as a template repository or false to prevent it |
| [KeysUrl](GithubClient.Repositories.Repository.KeysUrl 'GithubClient.Repositories.Repository.KeysUrl') | Github API Endpoint Url |
| [LabelsUrl](GithubClient.Repositories.Repository.LabelsUrl 'GithubClient.Repositories.Repository.LabelsUrl') | Github API Endpoint Url |
| [Language](GithubClient.Repositories.Repository.Language 'GithubClient.Repositories.Repository.Language') | Repository Language |
| [LanguagesUrl](GithubClient.Repositories.Repository.LanguagesUrl 'GithubClient.Repositories.Repository.LanguagesUrl') | Github API Endpoint Url |
| [License](GithubClient.Repositories.Repository.License 'GithubClient.Repositories.Repository.License') | License Object |
| [MergesUrl](GithubClient.Repositories.Repository.MergesUrl 'GithubClient.Repositories.Repository.MergesUrl') | Github API Endpoint Url |
| [MilestonesUrl](GithubClient.Repositories.Repository.MilestonesUrl 'GithubClient.Repositories.Repository.MilestonesUrl') | Github API Endpoint Url |
| [MirrorUrl](GithubClient.Repositories.Repository.MirrorUrl 'GithubClient.Repositories.Repository.MirrorUrl') | Mirror Url |
| [Name](GithubClient.Repositories.Repository.Name 'GithubClient.Repositories.Repository.Name') | The name of the repository. |
| [NodeId](GithubClient.Repositories.Repository.NodeId 'GithubClient.Repositories.Repository.NodeId') | Id of a Node (Node is a generic term for an object) used in GraphQL |
| [NotificationsUrl](GithubClient.Repositories.Repository.NotificationsUrl 'GithubClient.Repositories.Repository.NotificationsUrl') | Github API Endpoint Url |
| [OpenIssues](GithubClient.Repositories.Repository.OpenIssues 'GithubClient.Repositories.Repository.OpenIssues') | Count of Open issues |
| [OpenIssuesCount](GithubClient.Repositories.Repository.OpenIssuesCount 'GithubClient.Repositories.Repository.OpenIssuesCount') | Count of open issues |
| [Owner](GithubClient.Repositories.Repository.Owner 'GithubClient.Repositories.Repository.Owner') | Owner object |
| [Permissions](GithubClient.Repositories.Repository.Permissions 'GithubClient.Repositories.Repository.Permissions') | Permissions object |
| [Private](GithubClient.Repositories.Repository.Private 'GithubClient.Repositories.Repository.Private') | Either true to make the repository private or false to make it public |
| [PullsUrl](GithubClient.Repositories.Repository.PullsUrl 'GithubClient.Repositories.Repository.PullsUrl') | Github API Endpoint Url |
| [PushedAt](GithubClient.Repositories.Repository.PushedAt 'GithubClient.Repositories.Repository.PushedAt') | Most recent push |
| [ReleasesUrl](GithubClient.Repositories.Repository.ReleasesUrl 'GithubClient.Repositories.Repository.ReleasesUrl') | Github API Endpoint Url |
| [Size](GithubClient.Repositories.Repository.Size 'GithubClient.Repositories.Repository.Size') | Size in bytes |
| [SshUrl](GithubClient.Repositories.Repository.SshUrl 'GithubClient.Repositories.Repository.SshUrl') | Ssh Clone Url |
| [StargazersCount](GithubClient.Repositories.Repository.StargazersCount 'GithubClient.Repositories.Repository.StargazersCount') | Count of Stargazers |
| [StargazersUrl](GithubClient.Repositories.Repository.StargazersUrl 'GithubClient.Repositories.Repository.StargazersUrl') | Github API Endpoint Url |
| [StatusesUrl](GithubClient.Repositories.Repository.StatusesUrl 'GithubClient.Repositories.Repository.StatusesUrl') | Github API Endpoint Url |
| [SubscribersUrl](GithubClient.Repositories.Repository.SubscribersUrl 'GithubClient.Repositories.Repository.SubscribersUrl') | Github API Endpoint Url |
| [SubscriptionUrl](GithubClient.Repositories.Repository.SubscriptionUrl 'GithubClient.Repositories.Repository.SubscriptionUrl') | Github API Endpoint Url |
| [SvnUrl](GithubClient.Repositories.Repository.SvnUrl 'GithubClient.Repositories.Repository.SvnUrl') | Svn Clone Url |
| [TagsUrl](GithubClient.Repositories.Repository.TagsUrl 'GithubClient.Repositories.Repository.TagsUrl') | Github API Endpoint Url |
| [TeamsUrl](GithubClient.Repositories.Repository.TeamsUrl 'GithubClient.Repositories.Repository.TeamsUrl') | Github API Endpoint Url |
| [Topics](GithubClient.Repositories.Repository.Topics 'GithubClient.Repositories.Repository.Topics') | Topic List |
| [TreesUrl](GithubClient.Repositories.Repository.TreesUrl 'GithubClient.Repositories.Repository.TreesUrl') | Github API Endpoint Url |
| [UpdatedAt](GithubClient.Repositories.Repository.UpdatedAt 'GithubClient.Repositories.Repository.UpdatedAt') | Repository Update Date |
| [Visibility](GithubClient.Repositories.Repository.Visibility 'GithubClient.Repositories.Repository.Visibility') | Can be public or private |
| [Watchers](GithubClient.Repositories.Repository.Watchers 'GithubClient.Repositories.Repository.Watchers') | Number of watchers |
| [WatchersCount](GithubClient.Repositories.Repository.WatchersCount 'GithubClient.Repositories.Repository.WatchersCount') | Count of Watchers |
| [WebCommitSignoffRequired](GithubClient.Repositories.Repository.WebCommitSignoffRequired 'GithubClient.Repositories.Repository.WebCommitSignoffRequired') | True or False for signoff |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Repositories.Repository.GetApiUrl() 'GithubClient.Repositories.Repository.GetApiUrl()') | A method to return the API Url |
| [GetEndpoint(string, string)](GithubClient.Repositories.Repository.GetEndpoint(string,string) 'GithubClient.Repositories.Repository.GetEndpoint(string, string)') | |
| [GetHeader()](GithubClient.Repositories.Repository.GetHeader() 'GithubClient.Repositories.Repository.GetHeader()') | A method to return the default header |
| [GetOrgEndpoint(string)](GithubClient.Repositories.Repository.GetOrgEndpoint(string) 'GithubClient.Repositories.Repository.GetOrgEndpoint(string)') | |
| [GetOrgEndpoint(string, int, int)](GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int) 'GithubClient.Repositories.Repository.GetOrgEndpoint(string, int, int)') | |
| [GetOrgEndpoint(string, int, int, string, string)](GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int,string,string) 'GithubClient.Repositories.Repository.GetOrgEndpoint(string, int, int, string, string)') | |
| [PostEndpoint()](GithubClient.Repositories.Repository.PostEndpoint() 'GithubClient.Repositories.Repository.PostEndpoint()') | |
| [PostOrgEndpoint(string)](GithubClient.Repositories.Repository.PostOrgEndpoint(string) 'GithubClient.Repositories.Repository.PostOrgEndpoint(string)') | |
