using System.Text.Json.Serialization;

namespace GithubClient.Models
{
    /// <summary>
    /// A links object
    /// </summary>
    public class Links
    {
        /// <summary>
        /// Github API Url for this object
        /// </summary>
        [JsonPropertyName("self")]
        public string? Self { get; set; }
        /// <summary>
        /// Github API Url for this objects blob
        /// </summary>
        [JsonPropertyName("git")]
        public string? Git { get; set; }
        /// <summary>
        /// A Url to view this object in a browser
        /// </summary>
        [JsonPropertyName("html")]
        public string? Html { get; set; }
    }
    /// <summary>
    /// The contents of a file or directory in a repository
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/repos/contents">Github Docs : Contents</seealso>
    public class DirectoryContent
    {
        /// <summary>
        /// Name of the object
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// Path to the object
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; }
        /// <summary>
        /// The file's SHA-1 hash
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
        /// A Url to view this object in a browser
        /// </summary>
        [JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }
        /// <summary>
        /// Github API Url for this objects blob
        /// </summary>
        [JsonPropertyName("git_url")]
        public string? GitUrl { get; set; }
        /// <summary>
        /// The raw file download URl
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }
        /// <summary>
        /// file or dir
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// Collection of links
        /// </summary>
        [JsonPropertyName("_links")]
        public Links? Links { get; set; }
        /// <summary>
        /// A method to return the default header
        /// </summary>
        /// <returns>The recommended header</returns>
        public static string GetHeader()
        {
            return "application/vnd.github+json";
        }
    }
    /// <summary>
    /// The contents of a file or directory in a repository
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/repos/contents">Github Docs : Contents</seealso>
    public class FileContent
    {
        /// <summary>
        /// Name of the object
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// Path to the object
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; }
        /// <summary>
        /// The file's SHA-1 hash
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
        /// A Url to view this object in a browser
        /// </summary>
        [JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }
        /// <summary>
        /// Github API Url for this objects blob
        /// </summary>
        [JsonPropertyName("git_url")]
        public string? GitUrl { get; set; }
        /// <summary>
        /// The raw file download URl
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }
        /// <summary>
        /// file or dir
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        /// <summary>
        /// File content
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }
        /// <summary>
        /// Is always Base-64
        /// </summary>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }
        /// <summary>
        /// Collection of links
        /// </summary>
        [JsonPropertyName("_links")]
        public Links? Links { get; set; }
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