using System.Text.Json;
using System.Net.Http.Headers;
using GithubClient.Models;

namespace GithubClient.Methods
{
    /// <summary>
    /// A Collection of methods for working with Tree objects in the Github API
    /// </summary>
    public class Trees
    {
        /// <summary>
        /// Returns a repository Tree from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/git/trees">Github Docs : Trees</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <param name="Ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually master)</param>
        /// <returns>A tree object</returns>
        public static async Task<BaseTree> GetTree(string PAT, string Owner, string Name, string Ref = "main")
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = BaseTree.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Tree.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(BaseTree.GetApiUrl(Owner, Name, Ref));
            return JsonSerializer.Deserialize<BaseTree>(await Response);
        }
        /// <summary>
        /// Returns a repository Tree from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/git/trees">Github Docs : Trees</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="repository">A Repository object</param>
        /// <param name="Ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually master)</param>
        /// <param name="Recursive">Setting this parameter to any value returns the objects or subtrees referenced by the tree specified in :tree_sha</param>
        /// <returns>A tree object</returns>
        public static async Task<BaseTree>? GetTree(string PAT, Repository repository, string Ref = "main", bool Recursive = true)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = BaseTree.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Tree.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (repository.TreesUrl != null)
            {
                string RequestUrl = repository.TreesUrl.Replace("{/sha}", "/") + Ref + "?recursive=" + Recursive;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return JsonSerializer.Deserialize<BaseTree>(await Response);
            }
            return null;
        }
    }
}