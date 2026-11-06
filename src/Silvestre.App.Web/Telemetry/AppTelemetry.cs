using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenTelemetry.Exporter;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;

namespace Silvestre.App.Web.Telemetry;

/// <summary>
/// OTLP request metrics, enabled only when OTEL_EXPORTER_OTLP_ENDPOINT is set. Metrics only (no traces, no logs);
/// attributes are restricted to an allow-list so no query strings, IPs, user agents or URLs are exported.
/// </summary>
public static class AppTelemetry
{
    public const string ServiceName = "personal-website";

    public static readonly IReadOnlyList<string> AllowedTags = new[]
    {
        "http.request.method",
        "http.response.status_code",
        "http.route",
        "url.scheme",
        "network.protocol.name",
        "network.protocol.version",
    };

    public static bool IsEnabled(IConfiguration c) => !string.IsNullOrWhiteSpace(c["OTEL_EXPORTER_OTLP_ENDPOINT"]);

    public static IServiceCollection AddAppTelemetry(this IServiceCollection services, IConfiguration config)
    {
        if (!IsEnabled(config)) return services;

        var tags = AllowedTags.ToArray();
        services.AddOpenTelemetry()
            .ConfigureResource(r => r.AddService(ServiceName))
            .WithMetrics(m => m
                .AddAspNetCoreInstrumentation()
                .AddHttpClientInstrumentation()
                .AddRuntimeInstrumentation()
                .AddView(_ => new MetricStreamConfiguration { TagKeys = tags })
                .AddOtlpExporter(o => o.Protocol = OtlpExportProtocol.HttpProtobuf));
        return services;
    }
}
