using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Silvestre.App.Web.Tests;

public class ProjectsPageTests
{
    private static WebApplicationFactory<Program> Create() =>
        new WebApplicationFactory<Program>().WithWebHostBuilder(b => b.UseContentRoot(FindContentRoot()));

    private static string FindContentRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null && !File.Exists(Path.Combine(dir.FullName, "Silvestre.sln"))) dir = dir.Parent;
        if (dir is null) throw new InvalidOperationException("Silvestre.sln not found above the test output");
        return Path.Combine(dir.FullName, "src", "Silvestre.App.Web");
    }

    private static async Task<string> GetOk(HttpClient client, string path)
    {
        var response = await client.GetAsync(path);
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        return await response.Content.ReadAsStringAsync();
    }

    private static int Count(string haystack, string needle)
    {
        var count = 0;
        var i = 0;
        while ((i = haystack.IndexOf(needle, i, StringComparison.Ordinal)) >= 0) { count++; i += needle.Length; }
        return count;
    }

    [Theory]
    [InlineData("/projects", "Open the app")]
    [InlineData("/pt/projects", "Abrir a aplicação")]
    public async Task Projects_page_links_the_two_apps_in_order(string path, string label)
    {
        using var factory = Create();
        var html = await GetOk(factory.CreateClient(), path);

        Assert.Contains("href=\"https://baby.itssilvestre.com\"", html);
        Assert.Contains("href=\"https://bolinha.itssilvestre.com\"", html);
        Assert.Contains("target=\"_blank\"", html);
        Assert.Contains("data-umami-event-target=\"baby-play\"", html);
        Assert.Contains("data-umami-event-target=\"bolinha-play\"", html);
        Assert.Equal(2, Count(html, label));

        var ids = new[] { "planahead", "savvori", "homeos", "baby-play", "bolinha-play" }
            .Select(id => html.IndexOf($"id=\"{id}\"", StringComparison.Ordinal)).ToArray();
        Assert.All(ids, i => Assert.True(i >= 0));
        Assert.Equal(ids.OrderBy(i => i), ids);
    }

    [Theory]
    [InlineData("/")]
    [InlineData("/pt")]
    public async Task Home_page_does_not_mention_the_new_apps(string path)
    {
        using var factory = Create();
        var html = await GetOk(factory.CreateClient(), path);

        Assert.DoesNotContain("Baby Play", html);
        Assert.DoesNotContain("Bolinha Interactiva", html);
    }
}
