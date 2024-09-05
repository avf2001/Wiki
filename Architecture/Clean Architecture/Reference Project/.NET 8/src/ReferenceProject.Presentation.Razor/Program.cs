using Microsoft.EntityFrameworkCore;
using ReferenceProject.Infrastructure.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// TODO: Move services registration to separate extension method
#region Begin

builder.Services.AddRazorPages();

builder.Services.AddInfrastructure(options => 
    {
        var connectionString = builder.Configuration.GetConnectionString("ConnectionString");
        options.UseSqlite(connectionString); 
    }
);
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()));

new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();
builder.Services.AddLogging(builder => builder.AddSerilog());

#endregion

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

app.Run();
