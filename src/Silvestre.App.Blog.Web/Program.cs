using Silvestre.App.Blog.Web.Blog;
using Silvestre.App.Blog.Web.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<FeedOptions>(builder.Configuration.GetSection("Feeds"));

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
