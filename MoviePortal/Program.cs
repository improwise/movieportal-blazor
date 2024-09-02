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

// Add TMDB API key from environment variable
var tmdbApiKey = builder.Configuration["TMDB_API_KEY"] ?? Environment.GetEnvironmentVariable("TMDB_API_KEY");
builder.Configuration["TMDB_API_KEY"] = tmdbApiKey;

await builder.Build().RunAsync();