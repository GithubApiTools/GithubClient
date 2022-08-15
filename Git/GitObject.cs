using System.Text.Json.Serialization;

namespace GithubClient.Git
{
    /// <summary>
    /// The Git Database API gives you access to read and write raw Git objects to your Git database on GitHub and to list and update your references (branch heads and tags)
    /// </summary>
    /// <seealso href="https://docs.github.com/en/rest/git">Git Database</seealso>
    public class GitObject
    {
        /// <summary>
        /// The file's SHA-1 hash is computed and stored in the blob object
        /// </summary>
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }
        /// <summary>
        /// Github API Url for this object
        /// </summary>
        [JsonPropertyName("url")]
        public Uri? Url { get; set; }
    }
}