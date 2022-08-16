using System.Net.Http.Headers;
using GithubClient.Git;
using GithubClient.Repositories;
using System.Net.Http.Json;

namespace GithubClient.Methods
{
    internal class BlobClient
    {
        private readonly HttpClient _httpClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseAddress"></param>
        /// <param name="header"></param>
        /// <param name="pat"></param>
        public BlobClient(HttpClient httpClient, Uri baseAddress, string header, string pat)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseAddress;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Github Api BlobClient");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", pat);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Blob>> GetStreamAsync(Uri endpoint) =>
            await _httpClient.GetFromJsonAsync<IEnumerable<Blob>>(endpoint);
    }
    /// <summary>
    /// A Collection of methods for working with Blob objects in the Github API
    /// </summary>
    public class Blobs
    {
        /// <summary>
        /// Returns a blob object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/git/blobs">Github Docs : Blob</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <param name="Sha">Secure hashing algorithm</param>
        /// <returns>A blob object</returns>
        public static async Task<IEnumerable<Blob>>? GetBlob(string PAT, string Owner, string Name, string Sha)
        {
            BlobClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            IEnumerable<Blob> Response = await client.GetStreamAsync(Blob.GetEndpoint(Owner, Name, Sha));
            return Response;
        }
        /// <summary>
        /// Returns a blob object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/git/blobs">Github Docs : Blob</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="content">The contents of a file or directory in a repository.</param>
        /// <returns>A blob object</returns>
        public static async Task<IEnumerable<Blob>>? GetBlob(string PAT, ContentDirectory content)
        {
            BlobClient client = new(new HttpClient(), Blob.GetApiUrl(), Blob.GetHeader(), PAT);
            if (content.GitUrl != null)
            {
                IEnumerable<Blob> Response = await client.GetStreamAsync(new Uri(content.GitUrl));
                return Response;
            }
            return null;
        }
    }
}