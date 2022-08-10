using System.Text.Json;
using System.Net.Http.Headers;
using GithubClient.Models;

namespace GithubClient.Contents
{
    /// <summary>
    /// A Collection of methods for working with Content objects in the Github API
    /// </summary>
    public class Methods
    {
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="GithubUrl">Github API Url</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <returns>A DirectoryContent object</returns>
        public static async Task<List<DirectoryContent>> GetContents(string PAT, string GithubUrl, string Owner, string Name)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(GithubUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            string RequestUrl = GithubUrl + "/repos/" + Owner + "/" + Name + "/contents";
            Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
            return JsonSerializer.Deserialize<List<DirectoryContent>>(await Response);
        }
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="GithubUrl">Github API Url</param>
        /// <param name="repository">A Repository object</param>
        /// <param name="Ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually master)</param>
        /// <returns>A DirectoryContent object</returns>
        public static async Task<List<DirectoryContent>> GetContents(string PAT, string GithubUrl, Repository repository, string Ref = "main")
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(GithubUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (repository.ContentsUrl != null)
            {
                string RequestUrl = repository.ContentsUrl.Replace("/{+path}", "") + "?ref=" + Ref;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return JsonSerializer.Deserialize<List<DirectoryContent>>(await Response);
            }
            else
            {
                return new List<DirectoryContent>();
            }
        }
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="GithubUrl">Github API Url</param>
        /// <param name="content">A DirectoryContent object</param>
        /// <param name="Ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually master)</param>
        /// <returns>A DirectoryContent object</returns>
        public static async Task<List<DirectoryContent>> GetContents(string PAT, string GithubUrl, DirectoryContent content, string Ref = "main")
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(GithubUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (content.Url != null)
            {
                string RequestUrl = content.Url;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return JsonSerializer.Deserialize<List<DirectoryContent>>(await Response);
            }
            else
            {
                return new List<DirectoryContent>();
            }
        }
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="GithubUrl">Github API Url</param>
        /// <param name="content">A DirectoryContent object</param>
        /// <returns>A FileContent object</returns>
        public static async Task<FileContent> GetFile(string PAT, string GithubUrl, DirectoryContent content)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(GithubUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (content.DownloadUrl != null)
            {
                string RequestUrl = content.DownloadUrl;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return JsonSerializer.Deserialize<FileContent>(await Response);
            }
            else
            {
                return new FileContent();
            }
        }
    }
}