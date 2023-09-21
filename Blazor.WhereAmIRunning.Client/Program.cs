using Blazing.Common.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IUtilityService, UtilityService>();

await builder.Build().RunAsync();
