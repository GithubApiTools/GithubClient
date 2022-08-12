using System.Text.Json;
using System.Net.Http.Headers;
using GithubClient.Models;

namespace GithubClient.Methods
{
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
        public static async Task<Blob> GetBlob(string PAT, string Owner, string Name, string Sha)
        {
            HttpClient client = new()
            {
                BaseAddress = Blob.GetApiUrl()
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Blob.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            Task<Stream> Response = client.GetStreamAsync(Blob.GetApiUrl(Owner, Name, Sha));
            return JsonSerializer.Deserialize<Blob>(await Response);
        }
        /// <summary>
        /// Returns a blob object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/git/blobs">Github Docs : Blob</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="content">The contents of a file or directory in a repository.</param>
        /// <returns>A blob object</returns>
        public static async Task<Blob>? GetBlob(string PAT, DirectoryContent content)
        {
            HttpClient client = new()
            {
                BaseAddress = Blob.GetApiUrl()
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Blob.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (content.GitUrl != null)
            {
                string RequestUrl = content.GitUrl;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return JsonSerializer.Deserialize<Blob>(await Response);
            }
            return null;
        }
        /// <summary>
        /// Returns a blob object from the Github API
        /// </summary>
        /// <seealso href="https://docs.github.com/en/rest/git/blobs">Github Docs : Blob</seealso>
        /// <param name="PAT">Personal Access Token</param>
        /// <param name="tree">Object specifying a tree structure.</param>
        /// <returns>A blob object</returns>
        public static async Task<Blob>? GetBlob(string PAT, Tree tree)
        {
            HttpClient client = new()
            {
                BaseAddress = Blob.GetApiUrl()
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Blob.GetHeader()));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", PAT);
            client.DefaultRequestHeaders.Add("User-Agent", "Github Api Client");
            if (tree.Url != null)
            {
                string RequestUrl = tree.Url;
                Task<Stream> Response = client.GetStreamAsync(new Uri(RequestUrl));
                return JsonSerializer.Deserialize<Blob>(await Response);
            }
            return null;
        }
    }
}