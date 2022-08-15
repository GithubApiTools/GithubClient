using System.Text.Json.Serialization;

namespace GithubClient.Git
{
    /// <summary>
    /// A Git blob (binary large object) is the object type used to store the contents of each file in a repository.
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/git/blobs">Github Docs : Blobs</seealso>
    public class Blob : GitObject
    {
        /// <summary>
        /// Github API Url
        /// </summary>
        private static readonly string Api = "https://api.github.com";
        /// <summary>
        /// Id of a Node (Node is a generic term for an object) used in GraphQL
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
        /// <summary>
        /// File Contents
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }
        /// <summary>
        /// The encoding used for content. Currently, "utf-8" and "base64" are supported.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? HighlightedContent { get; set; }
        /// <summary>
        /// Default ctor with required properties
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encoding"></param>
        public Blob(string content, string encoding)
        {
            Content = content;
            Encoding = encoding;
        }
        /// <summary>
        /// A method to return the default header
        /// </summary>
        /// <returns>The recommended header</returns>
        public static string GetHeader()
        {
            return "application/vnd.github+json";
        }
        /// <summary>
        /// A method to return the API Url
        /// </summary>
        /// <returns></returns>
        public static Uri GetApiUrl()
        {
            return new Uri(Api);
        }
        /// <summary>
        /// The endpoint used to post a blob to the API
        /// </summary>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        /// <seealso href="https://docs.github.com/en/rest/git/blobs#create-a-blob">Create a Blob</seealso>
        public static Uri PostEndpoint(string Owner, string Repo)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Repo + "/git/blobs");
        }
        /// <summary>
        /// The endpoint used to get a blob from the API
        /// </summary>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="FileSha">Secure hashing algorithm</param>
        /// <returns></returns>
        /// <remarks>The content in the response will always be Base64 encoded.</remarks>
        /// <remarks>This API supports blobs up to 100 megabytes in size.</remarks>
        /// <seealso href="https://docs.github.com/en/rest/git/blobs#get-a-blob">Get a Blob</seealso>
        public static Uri GetEndpoint(string Owner, string Repo, string FileSha)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Repo + "/git/blobs/" + FileSha);
        }
    }
}