using System.Net.Http.Headers;
using GithubClient.Git;
using GithubClient.Repositories;
using System.Net.Http.Json;
using System.Xml.Linq;

namespace GithubClient.Methods
{
    internal class RepoClient
    {
        private readonly HttpClient _httpClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseAddress"></param>
        /// <param name="header"></param>
        /// <param name="pat"></param>
        public RepoClient(HttpClient httpClient, Uri baseAddress, string header, string pat)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseAddress;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Github Api RepoClient");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", pat);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Repository>> GetStreamAsync(Uri endpoint) =>
            await _httpClient.GetFromJsonAsync<IEnumerable<Repository>>(endpoint);
    }

    /// <summary>
    /// A Collection of methods for working with Repository objects in the Github API
    /// </summary>
    public class Repos
    {
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <returns>A repository object</returns>
        public static async Task<IEnumerable<Repository>>? GetRepository(string PAT, string Owner, string Name)
        {
            RepoClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<Repository> Response = await client.GetStreamAsync(Repository.GetEndpoint(Owner, Name));
            return Response;
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <returns>A collection of repository objects</returns>
        public static async Task<IEnumerable<Repository>>? GetOrgRepositories(string PAT, string Org)
        {
            RepoClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<Repository> Response = await client.GetStreamAsync(Repository.GetOrgEndpoint(Org));
            return Response;
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="PerPage">The number of results per page (max 100).</param>
        /// <param name="Page">Page number of the results to fetch</param>
        /// <returns>A collection of repository objects</returns>
        public static async Task<IEnumerable<Repository>>? GetOrgRepositories(string PAT, string Org, int PerPage = 30, int Page = 1)
        {
            RepoClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<Repository> Response = await client.GetStreamAsync(Repository.GetOrgEndpoint(Org, PerPage, Page));
            return Response;
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="PerPage">The number of results per page (max 100).</param>
        /// <param name="Page">Page number of the results to fetch</param>
        /// <param name="Type">Specifies the types of repositories you want returned.</param>
        /// <param name="Direction">The order to sort by. Default: asc</param>
        /// <returns>A collection of repository objects</returns>
        public static async Task<IEnumerable<Repository>>? GetOrgRepositories(string PAT, string Org, int PerPage = 30, int Page = 1, string Type = "all", string Direction = "asc")
        {
            RepoClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<Repository> Response = await client.GetStreamAsync(Repository.GetOrgEndpoint(Org, PerPage, Page, Type, Direction));
            return Response;
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <returns>A repository object</returns>
        public static async Task<IEnumerable<Repository>>? GetOrgRepository(string PAT, string Org, string Name)
        {
            RepoClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<Repository> Response = await client.GetStreamAsync(Repository.GetEndpoint(Org, Name));
            return Response;
        }
    }
}