using UnmessyExample.BlazorWebApp.Components;
using UnmessyExample.Application;
using UnmessyExample.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

#region Layer Services Registration

// Add Application layer services.
builder.Services.AddApplication();

// Technically, there should be no reference to the Infrastructure layer.
// The important rule not broken is no code from this layer is accessing the Infrastructure layer, only Application.
// It's accepted as the composition root exception.
builder.Services.AddInfrastructure();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
