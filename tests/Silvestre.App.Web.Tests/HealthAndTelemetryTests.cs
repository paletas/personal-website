using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using OpenTelemetry.Metrics;
using Silvestre.App.Web.Telemetry;

namespace Silvestre.App.Web.Tests;

public class HealthAndTelemetryTests
{
    private static WebApplicationFactory<Program> Create(string endpoint) =>
        new WebApplicationFactory<Program>().WithWebHostBuilder(b =>
        {
            b.UseContentRoot(FindContentRoot());
            b.UseSetting("OTEL_EXPORTER_OTLP_ENDPOINT", endpoint);
        });

    private static string FindContentRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null && !File.Exists(Path.Combine(dir.FullName, "Silvestre.sln"))) dir = dir.Parent;
        if (dir is null) throw new InvalidOperationException("Silvestre.sln not found above the test output");
        return Path.Combine(dir.FullName, "src", "Silvestre.App.Web");
    }

    [Fact]
    public async Task Health_returns_200()
    {
        using var factory = Create("");
        var client = factory.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
        var res = await client.GetAsync("/health");
        Assert.Equal(System.Net.HttpStatusCode.OK, res.StatusCode);
        Assert.Equal("Healthy", await res.Content.ReadAsStringAsync());
    }

    [Fact]
    public void Starts_without_endpoint_and_registers_no_meter_provider()
    {
        using var factory = Create("");
        Assert.Null(factory.Services.GetService<MeterProvider>());
    }

    [Fact]
    public async Task Endpoint_set_registers_meter_provider_and_site_still_serves()
    {
        using var factory = Create("http://127.0.0.1:4318");
        Assert.NotNull(factory.Services.GetService<MeterProvider>());
        var client = factory.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
        var res = await client.GetAsync("/health");
        Assert.Equal(System.Net.HttpStatusCode.OK, res.StatusCode);
    }

    [Fact]
    public void Allow_list_has_no_identifying_keys()
    {
        Assert.Equal(new[]
        {
            "http.request.method", "http.response.status_code", "http.route",
            "url.scheme", "network.protocol.name", "network.protocol.version",
        }, AppTelemetry.AllowedTags);
        foreach (var bad in new[] { "url.full", "url.query", "url.path", "client.address", "user_agent.original", "server.address" })
            Assert.DoesNotContain(bad, AppTelemetry.AllowedTags);
    }
}
