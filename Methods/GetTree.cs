using System.Net.Http.Headers;
using GithubClient.Git;
using GithubClient.Repositories;
using System.Net.Http.Json;
using System.Xml.Linq;

namespace GithubClient.Methods
{
    internal class TreeClient
    {
        private readonly HttpClient _httpClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseAddress"></param>
        /// <param name="header"></param>
        /// <param name="pat"></param>
        public TreeClient(HttpClient httpClient, Uri baseAddress, string header, string pat)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseAddress;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Github Api TreeClient");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", pat);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<IEnumerable<BaseTree>> GetStreamAsync(Uri endpoint) =>
            await _httpClient.GetFromJsonAsync<IEnumerable<BaseTree>>(endpoint);
    }
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
        public static async Task<IEnumerable<BaseTree>>? GetTree(string PAT, string Owner, string Name, string Ref = "main")
        {
            TreeClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<BaseTree> Response = await client.GetStreamAsync(BaseTree.GetEndpoint(Owner, Name, Ref));
            return Response;
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
        public static async Task<IEnumerable<BaseTree>>? GetTree(string PAT, Repository repository, string Ref = "main", bool Recursive = true)
        {
            TreeClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            if (repository.TreesUrl != null)
            {
                string RequestUrl = repository.TreesUrl.Replace("{/sha}", "/") + Ref + "?recursive=" + Recursive;
                IEnumerable<BaseTree> Response = await client.GetStreamAsync(new Uri(RequestUrl));
                return Response;
            }
            return null;
        }
    }
}