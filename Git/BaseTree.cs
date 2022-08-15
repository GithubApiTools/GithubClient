using System.Text.Json.Serialization;

namespace GithubClient.Git
{
    /// <summary>
    /// A Git tree object creates the hierarchy between files in a Git repository
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/git/trees">Github Docs : Trees</seealso>
    public class BaseTree : GitObject
    {
        /// <summary>
        /// Github API Url
        /// </summary>
        private static readonly string Api = "https://api.github.com";
        /// <summary>
        /// A collection of Tree objects
        /// </summary>
        [JsonPropertyName("tree")]
        public List<Tree>? Tree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("truncated")]
        public bool Truncated { get; set; }
        /// <summary>
        /// Default ctor with required properties
        /// </summary>
        /// <param name="tree"></param>
        public BaseTree(List<Tree>? tree)
        {
            Tree = tree;
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
        /// The endpoint used to post a tree to the API
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repo"></param>
        /// <returns></returns>
        public static Uri PostEndpoint(string Owner, string Repo)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Repo + "/git/trees");
        }
        /// <summary>
        /// The endpoint used to get a tree from the API
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repo"></param>
        /// <param name="TreeSha"></param>
        /// <returns></returns>
        public static Uri GetEndpoint(string Owner, string Repo, string TreeSha)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Repo + "/git/trees/" + TreeSha);
        }
    }
}