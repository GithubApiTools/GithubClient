using System.Net.Http.Headers;
using GithubClient.Git;
using GithubClient.Repositories;
using System.Net.Http.Json;

namespace GithubClient.Methods
{
    internal class ContentClient
    {
        private readonly HttpClient _httpClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseAddress"></param>
        /// <param name="header"></param>
        /// <param name="pat"></param>
        public ContentClient(HttpClient httpClient, Uri baseAddress, string header, string pat)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseAddress;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Github Api ContentClient");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", pat);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ContentDirectory>> GetStreamAsync(Uri endpoint) =>
            await _httpClient.GetFromJsonAsync<IEnumerable<ContentDirectory>>(endpoint);
    }
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
        public static async Task<IEnumerable<ContentDirectory>>? GetContents(string PAT, string Owner, string Name)
        {
            ContentClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<ContentDirectory> Response = await client.GetStreamAsync(ContentDirectory.GetEndpointUrl(Owner, Name));
            return Response;
        }
        /// <summary>
        /// Returns a content object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/repos/contents#get-repository-content">Github Docs : Contents</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="repository">A Repository object</param>
        /// <param name="Ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually master)</param>
        /// <returns>A DirectoryContent object</returns>
        public static async Task<IEnumerable<ContentDirectory>>? GetContents(string PAT, Repository repository, string Ref = "main")
        {
            ContentClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            if (repository.ContentsUrl != null)
            {
                string RequestUrl = repository.ContentsUrl.Replace("/{+path}", "") + "?ref=" + Ref;
                IEnumerable<ContentDirectory> Response = await client.GetStreamAsync(new Uri(RequestUrl));
                return Response;
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
        public static async Task<IEnumerable<ContentDirectory>>? GetContents(string PAT, ContentDirectory content)
        {
            ContentClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            if (content.Url != null)
            {
                IEnumerable<ContentDirectory> Response = await client.GetStreamAsync(content.Url);
                return Response;
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