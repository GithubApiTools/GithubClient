using System.Text.Json;
using System.Net.Http.Headers;
using GithubClient.Models;

namespace GithubClient.Methods
{
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
        /// <returns>A collection of repository objects</returns>
        public static async Task<List<Repository>>? GetRepositories(string PAT, string Owner)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(Repository.GetApiUrl(Owner, false));
            return JsonSerializer.Deserialize<List<Repository>>(await Response);
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="PerPage">The number of results per page (max 100).</param>
        /// <param name="Page">Page number of the results to fetch</param>
        /// <returns>A collection of repository objects</returns>
        public static async Task<List<Repository>> GetRepositories(string PAT, string Owner, int PerPage = 30, int Page = 1)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            string RequestUrl = Repository.GetApiUrl() + "/repos/" + Owner + "/repos?per_page=" + PerPage + "&page=" + Page;
            Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
            return JsonSerializer.Deserialize<List<Repository>>(await Response);
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="PerPage">The number of results per page (max 100).</param>
        /// <param name="Page">Page number of the results to fetch</param>
        /// <param name="Type">Specifies the types of repositories you want returned.</param>
        /// <param name="Direction">The order to sort by. Default: asc</param>
        /// <returns>A collection of repository objects</returns>
        public static async Task<List<Repository>> GetRepositories(string PAT, string Owner, int PerPage = 30, int Page = 1, string Type = "all", string Direction = "asc")
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            string RequestUrl = Repository.GetApiUrl() + "/repos/" + Owner + "/repos?per_page=" + PerPage + "&page=" + Page + "&type=" + Type + "&direction=" + Direction;
            Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
            return JsonSerializer.Deserialize<List<Repository>>(await Response);
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <returns>A repository object</returns>
        public static async Task<Repository> GetRepository(string PAT, string Owner, string Name)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(Repository.GetApiUrl(Owner, Name));
            return JsonSerializer.Deserialize<Repository>(await Response);
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <returns>A collection of repository objects</returns>
        public static async Task<List<Repository>> GetOrgRepositories(string PAT, string Org)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(Repository.GetApiUrl(Org, true));
            return JsonSerializer.Deserialize<List<Repository>>(await Response);
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
        public static async Task<List<Repository>> GetOrgRepositories(string PAT, string Org, int PerPage = 30, int Page = 1)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(Repository.GetApiUrl(Org, PerPage, Page, true));
            return JsonSerializer.Deserialize<List<Repository>>(await Response);
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
        public static async Task<List<Repository>> GetOrgRepositories(string PAT, string Org, int PerPage = 30, int Page = 1, string Type = "all", string Direction = "asc")
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync((Repository.GetApiUrl(Org, PerPage, Page, Type, Direction, true)));
            return JsonSerializer.Deserialize<List<Repository>>(await Response);
        }
        /// <summary>
        /// Returns a repository object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/repos">Github Docs : Repos</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Org">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <returns>A repository object</returns>
        public static async Task<Repository> GetOrgRepository(string PAT, string Org, string Name)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = Repository.GetApiUrl();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Repository.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(Repository.GetApiUrl(Org, Name));
            return JsonSerializer.Deserialize<Repository>(await Response);
        }
    }
}