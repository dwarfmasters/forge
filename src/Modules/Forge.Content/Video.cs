namespace Forge.Content;

/// <summary>A single video from the Dwarfmasters YouTube channel.</summary>
public sealed record Video(string Id, string Title, string Url, DateTimeOffset PublishedAt);
