using Forge.Content;

namespace Forge.Tests;

public class SmokeTests
{
    [Fact]
    public void Video_records_with_same_values_are_equal()
    {
        var published = new DateTimeOffset(2026, 10, 27, 20, 0, 0, TimeSpan.FromHours(1));
        var a = new Video("abc", "Die Evakuierung", "https://youtu.be/abc", published);
        var b = new Video("abc", "Die Evakuierung", "https://youtu.be/abc", published);

        Assert.Equal(a, b);
    }
}
