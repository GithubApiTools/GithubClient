using System.Text.Json.Serialization;

namespace GithubClient.Models
{
    /// <summary>
    /// A Git tree object creates the hierarchy between files in a Git repository
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/git/trees">Github Docs : Trees</seealso>
    public class TreeRoot
    {
        /// <summary>
        /// The object's SHA-1 hash
        /// </summary>
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }
        /// <summary>
        /// Github API Url for this object
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }
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
    }
    /// <summary>
    /// A Git tree object creates the hierarchy between files in a Git repository
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/git/trees">Github Docs : Trees</seealso>
    public class Tree
    {
        /// <summary>
        /// Path to the object
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; }
        /// <summary>
        /// The file mode; one of 100644 for file (blob), 100755 for executable (blob), 040000 for subdirectory (tree), 160000 for submodule (commit), or 120000 for a blob that specifies the path of a symlink.
        /// </summary>
        [JsonPropertyName("mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// Either blob, tree, or commit
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// The object's SHA-1 hash
        /// </summary>
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }
        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
        /// <summary>
        /// Github API Url for this object
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        /// <summary>
        /// A method to return the default header
        /// </summary>
        /// <returns>The recommended header</returns>
        public static string GetHeader()
        {
            return "application/vnd.github+json";
        }
    }
}