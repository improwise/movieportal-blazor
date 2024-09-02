using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MoviePortal;
using MoviePortal.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<TmdbApiService>();
builder.Services.AddScoped<GenreService>();

// Load configuration
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
if (builder.HostEnvironment.IsDevelopment())
{
    builder.Configuration.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
}

await builder.Build().RunAsync();