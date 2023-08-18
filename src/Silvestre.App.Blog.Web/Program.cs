using Silvestre.App.Blog.Web.Blog;
using Silvestre.App.Blog.Web.Options;

var builder = WebApplication.CreateBuilder(args);

IConfigurationSection feedSection = builder.Configuration.GetSection("Feeds");
FeedOptions feedOptions = feedSection.Get<FeedOptions>() ?? throw new InvalidOperationException();
builder.Services.Configure<FeedOptions>(feedSection);

builder.Services.AddScoped<IBlogRepository, LocalBlogRepository>(sp => new LocalBlogRepository("Blog/Content", loadDrafts: builder.Environment.IsDevelopment()));

builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        ctx.Context.Response.Headers.CacheControl = new Microsoft.Extensions.Primitives.StringValues(new[] { "public", $"max-age={TimeSpan.FromDays(365).TotalSeconds}" });
    },
    HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
    ServeUnknownFileTypes = true
});

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
