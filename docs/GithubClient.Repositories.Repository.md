#### [GithubClient](index.md 'index')
### [GithubClient.Repositories](GithubClient.Repositories.md 'GithubClient.Repositories')

## Repository Class

The ultimate source for the network

```csharp
public class Repository : GithubClient.Repositories.GitObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [GitObject](GithubClient.Repositories.GitObject.md 'GithubClient.Repositories.GitObject') &#129106; Repository

### See Also
- [Github Docs : Repositories](https://docs.github.com/en/rest/repos/repos 'https://docs.github.com/en/rest/repos/repos')

| Constructors | |
| :--- | :--- |
| [Repository(string)](GithubClient.Repositories.Repository.Repository(string).md 'GithubClient.Repositories.Repository.Repository(string)') | Default ctor with required properties |

| Fields | |
| :--- | :--- |
| [Api](GithubClient.Repositories.Repository.Api.md 'GithubClient.Repositories.Repository.Api') | Github API Url |

| Properties | |
| :--- | :--- |
| [AllowForking](GithubClient.Repositories.Repository.AllowForking.md 'GithubClient.Repositories.Repository.AllowForking') | Either true to allow private forks, or false to prevent private forks |
| [Archived](GithubClient.Repositories.Repository.Archived.md 'GithubClient.Repositories.Repository.Archived') | true to archive this repository. Note: You cannot unarchive repositories through the API |
| [ArchiveUrl](GithubClient.Repositories.Repository.ArchiveUrl.md 'GithubClient.Repositories.Repository.ArchiveUrl') | Github API Endpoint Url |
| [AssigneesUrl](GithubClient.Repositories.Repository.AssigneesUrl.md 'GithubClient.Repositories.Repository.AssigneesUrl') | Github API Endpoint Url |
| [BlobsUrl](GithubClient.Repositories.Repository.BlobsUrl.md 'GithubClient.Repositories.Repository.BlobsUrl') | Github API Endpoint Url |
| [BranchesUrl](GithubClient.Repositories.Repository.BranchesUrl.md 'GithubClient.Repositories.Repository.BranchesUrl') | Github API Endpoint Url |
| [CloneUrl](GithubClient.Repositories.Repository.CloneUrl.md 'GithubClient.Repositories.Repository.CloneUrl') | Http Clone Url |
| [CollaboratorsUrl](GithubClient.Repositories.Repository.CollaboratorsUrl.md 'GithubClient.Repositories.Repository.CollaboratorsUrl') | Github API Endpoint Url |
| [CommentsUrl](GithubClient.Repositories.Repository.CommentsUrl.md 'GithubClient.Repositories.Repository.CommentsUrl') | Github API Endpoint Url |
| [CommitsUrl](GithubClient.Repositories.Repository.CommitsUrl.md 'GithubClient.Repositories.Repository.CommitsUrl') | Github API Endpoint Url |
| [CompareUrl](GithubClient.Repositories.Repository.CompareUrl.md 'GithubClient.Repositories.Repository.CompareUrl') | Github API Endpoint Url |
| [ContentsUrl](GithubClient.Repositories.Repository.ContentsUrl.md 'GithubClient.Repositories.Repository.ContentsUrl') | Github API Endpoint Url |
| [ContributorsUrl](GithubClient.Repositories.Repository.ContributorsUrl.md 'GithubClient.Repositories.Repository.ContributorsUrl') | Github API Endpoint Url |
| [CreatedAt](GithubClient.Repositories.Repository.CreatedAt.md 'GithubClient.Repositories.Repository.CreatedAt') | Repository Creation Date |
| [DefaultBranch](GithubClient.Repositories.Repository.DefaultBranch.md 'GithubClient.Repositories.Repository.DefaultBranch') | Default repository branch |
| [DeploymentsUrl](GithubClient.Repositories.Repository.DeploymentsUrl.md 'GithubClient.Repositories.Repository.DeploymentsUrl') | Github API Endpoint Url |
| [Description](GithubClient.Repositories.Repository.Description.md 'GithubClient.Repositories.Repository.Description') | A short description of the repository |
| [Disabled](GithubClient.Repositories.Repository.Disabled.md 'GithubClient.Repositories.Repository.Disabled') | True or False |
| [DownloadsUrl](GithubClient.Repositories.Repository.DownloadsUrl.md 'GithubClient.Repositories.Repository.DownloadsUrl') | Github API Endpoint Url |
| [EventsUrl](GithubClient.Repositories.Repository.EventsUrl.md 'GithubClient.Repositories.Repository.EventsUrl') | Github API Endpoint Url |
| [Fork](GithubClient.Repositories.Repository.Fork.md 'GithubClient.Repositories.Repository.Fork') | True if this repository is forked |
| [Forks](GithubClient.Repositories.Repository.Forks.md 'GithubClient.Repositories.Repository.Forks') | Number of forks |
| [ForksCount](GithubClient.Repositories.Repository.ForksCount.md 'GithubClient.Repositories.Repository.ForksCount') | Count of Forks |
| [ForksUrl](GithubClient.Repositories.Repository.ForksUrl.md 'GithubClient.Repositories.Repository.ForksUrl') | Github API Endpoint Url |
| [FullName](GithubClient.Repositories.Repository.FullName.md 'GithubClient.Repositories.Repository.FullName') | A short description of the repository |
| [GitCommitsUrl](GithubClient.Repositories.Repository.GitCommitsUrl.md 'GithubClient.Repositories.Repository.GitCommitsUrl') | Github API Endpoint Url |
| [GitRefsUrl](GithubClient.Repositories.Repository.GitRefsUrl.md 'GithubClient.Repositories.Repository.GitRefsUrl') | Github API Endpoint Url |
| [GitTagsUrl](GithubClient.Repositories.Repository.GitTagsUrl.md 'GithubClient.Repositories.Repository.GitTagsUrl') | Github API Endpoint Url |
| [GitUrl](GithubClient.Repositories.Repository.GitUrl.md 'GithubClient.Repositories.Repository.GitUrl') | Git Clone Url |
| [HasDownloads](GithubClient.Repositories.Repository.HasDownloads.md 'GithubClient.Repositories.Repository.HasDownloads') | True or False if downloads are available |
| [HasIssues](GithubClient.Repositories.Repository.HasIssues.md 'GithubClient.Repositories.Repository.HasIssues') | Either true to enable issues for this repository or false to disable them |
| [HasPages](GithubClient.Repositories.Repository.HasPages.md 'GithubClient.Repositories.Repository.HasPages') | Either true to enable the pages for this repository or false to disable it. |
| [HasProjects](GithubClient.Repositories.Repository.HasProjects.md 'GithubClient.Repositories.Repository.HasProjects') | Either true to enable projects for this repository or false to disable them |
| [HasWiki](GithubClient.Repositories.Repository.HasWiki.md 'GithubClient.Repositories.Repository.HasWiki') | Either true to enable the wiki for this repository or false to disable it. |
| [Homepage](GithubClient.Repositories.Repository.Homepage.md 'GithubClient.Repositories.Repository.Homepage') | A URL with more information about the repository |
| [HooksUrl](GithubClient.Repositories.Repository.HooksUrl.md 'GithubClient.Repositories.Repository.HooksUrl') | Github API Endpoint Url |
| [HtmlUrl](GithubClient.Repositories.Repository.HtmlUrl.md 'GithubClient.Repositories.Repository.HtmlUrl') | A Url to view this object in a browser |
| [Id](GithubClient.Repositories.Repository.Id.md 'GithubClient.Repositories.Repository.Id') | Github Id |
| [IssueCommentUrl](GithubClient.Repositories.Repository.IssueCommentUrl.md 'GithubClient.Repositories.Repository.IssueCommentUrl') | Github API Endpoint Url |
| [IssueEventsUrl](GithubClient.Repositories.Repository.IssueEventsUrl.md 'GithubClient.Repositories.Repository.IssueEventsUrl') | Github API Endpoint Url |
| [IssuesUrl](GithubClient.Repositories.Repository.IssuesUrl.md 'GithubClient.Repositories.Repository.IssuesUrl') | Github API Endpoint Url |
| [IsTemplate](GithubClient.Repositories.Repository.IsTemplate.md 'GithubClient.Repositories.Repository.IsTemplate') | Either true to make this repo available as a template repository or false to prevent it |
| [KeysUrl](GithubClient.Repositories.Repository.KeysUrl.md 'GithubClient.Repositories.Repository.KeysUrl') | Github API Endpoint Url |
| [LabelsUrl](GithubClient.Repositories.Repository.LabelsUrl.md 'GithubClient.Repositories.Repository.LabelsUrl') | Github API Endpoint Url |
| [Language](GithubClient.Repositories.Repository.Language.md 'GithubClient.Repositories.Repository.Language') | Repository Language |
| [LanguagesUrl](GithubClient.Repositories.Repository.LanguagesUrl.md 'GithubClient.Repositories.Repository.LanguagesUrl') | Github API Endpoint Url |
| [License](GithubClient.Repositories.Repository.License.md 'GithubClient.Repositories.Repository.License') | License Object |
| [MergesUrl](GithubClient.Repositories.Repository.MergesUrl.md 'GithubClient.Repositories.Repository.MergesUrl') | Github API Endpoint Url |
| [MilestonesUrl](GithubClient.Repositories.Repository.MilestonesUrl.md 'GithubClient.Repositories.Repository.MilestonesUrl') | Github API Endpoint Url |
| [MirrorUrl](GithubClient.Repositories.Repository.MirrorUrl.md 'GithubClient.Repositories.Repository.MirrorUrl') | Mirror Url |
| [Name](GithubClient.Repositories.Repository.Name.md 'GithubClient.Repositories.Repository.Name') | The name of the repository. |
| [NodeId](GithubClient.Repositories.Repository.NodeId.md 'GithubClient.Repositories.Repository.NodeId') | Id of a Node (Node is a generic term for an object) used in GraphQL |
| [NotificationsUrl](GithubClient.Repositories.Repository.NotificationsUrl.md 'GithubClient.Repositories.Repository.NotificationsUrl') | Github API Endpoint Url |
| [OpenIssues](GithubClient.Repositories.Repository.OpenIssues.md 'GithubClient.Repositories.Repository.OpenIssues') | Count of Open issues |
| [OpenIssuesCount](GithubClient.Repositories.Repository.OpenIssuesCount.md 'GithubClient.Repositories.Repository.OpenIssuesCount') | Count of open issues |
| [Owner](GithubClient.Repositories.Repository.Owner.md 'GithubClient.Repositories.Repository.Owner') | Owner object |
| [Permissions](GithubClient.Repositories.Repository.Permissions.md 'GithubClient.Repositories.Repository.Permissions') | Permissions object |
| [Private](GithubClient.Repositories.Repository.Private.md 'GithubClient.Repositories.Repository.Private') | Either true to make the repository private or false to make it public |
| [PullsUrl](GithubClient.Repositories.Repository.PullsUrl.md 'GithubClient.Repositories.Repository.PullsUrl') | Github API Endpoint Url |
| [PushedAt](GithubClient.Repositories.Repository.PushedAt.md 'GithubClient.Repositories.Repository.PushedAt') | Most recent push |
| [ReleasesUrl](GithubClient.Repositories.Repository.ReleasesUrl.md 'GithubClient.Repositories.Repository.ReleasesUrl') | Github API Endpoint Url |
| [Size](GithubClient.Repositories.Repository.Size.md 'GithubClient.Repositories.Repository.Size') | Size in bytes |
| [SshUrl](GithubClient.Repositories.Repository.SshUrl.md 'GithubClient.Repositories.Repository.SshUrl') | Ssh Clone Url |
| [StargazersCount](GithubClient.Repositories.Repository.StargazersCount.md 'GithubClient.Repositories.Repository.StargazersCount') | Count of Stargazers |
| [StargazersUrl](GithubClient.Repositories.Repository.StargazersUrl.md 'GithubClient.Repositories.Repository.StargazersUrl') | Github API Endpoint Url |
| [StatusesUrl](GithubClient.Repositories.Repository.StatusesUrl.md 'GithubClient.Repositories.Repository.StatusesUrl') | Github API Endpoint Url |
| [SubscribersUrl](GithubClient.Repositories.Repository.SubscribersUrl.md 'GithubClient.Repositories.Repository.SubscribersUrl') | Github API Endpoint Url |
| [SubscriptionUrl](GithubClient.Repositories.Repository.SubscriptionUrl.md 'GithubClient.Repositories.Repository.SubscriptionUrl') | Github API Endpoint Url |
| [SvnUrl](GithubClient.Repositories.Repository.SvnUrl.md 'GithubClient.Repositories.Repository.SvnUrl') | Svn Clone Url |
| [TagsUrl](GithubClient.Repositories.Repository.TagsUrl.md 'GithubClient.Repositories.Repository.TagsUrl') | Github API Endpoint Url |
| [TeamsUrl](GithubClient.Repositories.Repository.TeamsUrl.md 'GithubClient.Repositories.Repository.TeamsUrl') | Github API Endpoint Url |
| [Topics](GithubClient.Repositories.Repository.Topics.md 'GithubClient.Repositories.Repository.Topics') | Topic List |
| [TreesUrl](GithubClient.Repositories.Repository.TreesUrl.md 'GithubClient.Repositories.Repository.TreesUrl') | Github API Endpoint Url |
| [UpdatedAt](GithubClient.Repositories.Repository.UpdatedAt.md 'GithubClient.Repositories.Repository.UpdatedAt') | Repository Update Date |
| [Visibility](GithubClient.Repositories.Repository.Visibility.md 'GithubClient.Repositories.Repository.Visibility') | Can be public or private |
| [Watchers](GithubClient.Repositories.Repository.Watchers.md 'GithubClient.Repositories.Repository.Watchers') | Number of watchers |
| [WatchersCount](GithubClient.Repositories.Repository.WatchersCount.md 'GithubClient.Repositories.Repository.WatchersCount') | Count of Watchers |
| [WebCommitSignoffRequired](GithubClient.Repositories.Repository.WebCommitSignoffRequired.md 'GithubClient.Repositories.Repository.WebCommitSignoffRequired') | True or False for signoff |

| Methods | |
| :--- | :--- |
| [GetApiUrl()](GithubClient.Repositories.Repository.GetApiUrl().md 'GithubClient.Repositories.Repository.GetApiUrl()') | A method to return the API Url |
| [GetEndpoint(string, string)](GithubClient.Repositories.Repository.GetEndpoint(string,string).md 'GithubClient.Repositories.Repository.GetEndpoint(string, string)') | |
| [GetHeader()](GithubClient.Repositories.Repository.GetHeader().md 'GithubClient.Repositories.Repository.GetHeader()') | A method to return the default header |
| [GetOrgEndpoint(string)](GithubClient.Repositories.Repository.GetOrgEndpoint(string).md 'GithubClient.Repositories.Repository.GetOrgEndpoint(string)') | |
| [GetOrgEndpoint(string, int, int)](GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int).md 'GithubClient.Repositories.Repository.GetOrgEndpoint(string, int, int)') | |
| [GetOrgEndpoint(string, int, int, string, string)](GithubClient.Repositories.Repository.GetOrgEndpoint(string,int,int,string,string).md 'GithubClient.Repositories.Repository.GetOrgEndpoint(string, int, int, string, string)') | |
| [PostEndpoint()](GithubClient.Repositories.Repository.PostEndpoint().md 'GithubClient.Repositories.Repository.PostEndpoint()') | |
| [PostOrgEndpoint(string)](GithubClient.Repositories.Repository.PostOrgEndpoint(string).md 'GithubClient.Repositories.Repository.PostOrgEndpoint(string)') | |
