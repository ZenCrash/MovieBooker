using MovieBooker.Client.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;
using MovieBooker.DataAccess.Repository;
using MovieBooker.DataAccess;
using MovieBooker.DataAccess.Model;
using MovieBooker.Client.Logic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//newnew
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<RoleRepository>();


builder.Services.AddDbContext <MovieBookerContext>();
builder.Services.AddIdentity<User, Role>(options => { 
    options.SignIn.RequireConfirmedAccount = false; })
    .AddEntityFrameworkStores<MovieBookerContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

//seed
using (var servinceScope = app.Services.CreateScope())
{
    await Seed.InitializeRolesAsync(servinceScope.ServiceProvider);
}

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //app.UseHsts();
    }

app.UseHttpsRedirection();

//security
app.UseAuthorization();
app.UseAuthentication();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
