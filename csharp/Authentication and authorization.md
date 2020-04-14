# Authentication

Custom storage providers for ASP.NET Core Identity
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity-custom-storage-providers?view=aspnetcore-3.1

Overview of ASP.NET Core authentication
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/?view=aspnetcore-3.1



```
public void ConfigureServices(IServiceCollection services)
{
  ...
  services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
  ...
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
  ...
  app.UseAuthentication();
  app.UseAuthorization();
  ...
}
```
Project > Context menu > Add... > New scaffolded item... > Left panel - Identity > Identity

SignInManager

UserManager

# Authorization
IAuthorizationService

Proposal
