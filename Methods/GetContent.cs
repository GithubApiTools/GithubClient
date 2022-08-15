using System.Text.Json;
using System.Net.Http.Headers;
using GithubClient.Repositories;

namespace GithubClient.Methods
{
    /// <summary>
    /// A Collection of methods for working with Content objects in the Github API
    /// </summary>
    public class Contents
    {
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <returns>A DirectoryContent object</returns>
        public static async Task<List<ContentDirectory>> GetContents(string PAT, string Owner, string Name)
        {
            HttpClient client = new()
            {
                BaseAddress = ContentDirectory.GetApiUrl()
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentDirectory.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(ContentDirectory.GetEndpointUrl(Owner, Name));
            return JsonSerializer.Deserialize<List<ContentDirectory>>(await Response);
        }
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="repository">A Repository object</param>
        /// <param name="Ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually master)</param>
        /// <returns>A DirectoryContent object</returns>
        public static async Task<List<ContentDirectory>>? GetContents(string PAT, Repository repository, string Ref = "main")
        {
            HttpClient client = new()
            {
                BaseAddress = ContentDirectory.GetApiUrl()
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentDirectory.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (repository.ContentsUrl != null)
            {
                string RequestUrl = repository.ContentsUrl.Replace("/{+path}", "") + "?ref=" + Ref;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return JsonSerializer.Deserialize<List<ContentDirectory>>(await Response);
            }
            return null;
        }
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="content">A DirectoryContent object</param>
        /// <returns>A DirectoryContent object</returns>
        public static async Task<List<ContentDirectory>>? GetContents(string PAT, ContentDirectory content)
        {
            HttpClient client = new()
            {
                BaseAddress = ContentDirectory.GetApiUrl()
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentDirectory.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (content.Url != null)
            {
                Task<Stream> Response = client.GetStreamAsync(content.Url);
                return JsonSerializer.Deserialize<List<ContentDirectory>>(await Response);
            }
            return null;
        }
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="content">A DirectoryContent object</param>
        /// <returns>A FileContent object</returns>
        public static async Task<object> GetFile(string PAT, ContentDirectory content)
        {
            HttpClient client = new()
            {
                BaseAddress = ContentDirectory.GetApiUrl()
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentFile.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (content.DownloadUrl != null)
            {
                string RequestUrl = content.DownloadUrl;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return await Response;
            }
            else
            {
                return null;
            }
        }
    }
}