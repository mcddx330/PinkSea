using System.Text.Json.Serialization;
using PinkSea.AtProto.Lexicons.Types;

namespace PinkSea.AtProto.Lexicons.Bluesky.Records;

/// <summary>
/// The image kept within image embed.
/// </summary>
public class Image
{
    /// <summary>
    /// The actual atproto image blob.
    /// </summary>
    [JsonPropertyName("image")]
    public required Blob Blob { get; set; }
    
    /// <summary>
    /// The alt-text
    /// </summary>
    [JsonPropertyName("alt")]
    public string? Alt { get; set; }
}