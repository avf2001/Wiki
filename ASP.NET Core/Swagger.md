# Подключение Swagger к проекту (на примере ASP.NET Core 3.1)
1. Подключить nuget пакет `Swashbuckle.AspNetCore`
```
install package Swashbuckle.AspNetCore
```
2. Метод `ConfigureServices` класса `Startup`
```csharp
public void ConfigureServices(IServiceCollection services)
{
	...
	services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASP.NET Core API", Version = "v1"}); });
	...
}
```
3. Метод `Configure` класса `Startup`
```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
	...
	
	if (env.IsDevelopment())
	{
		app.UseDeveloperExceptionPage();
	}

	app.UseSwagger();

	app.UseSwaggerUI(c => { c.SwaggerEndpoint("v1/swagger.json", "ASP.NET Core API Documentation"); });

	app.UseHttpsRedirection();
	
	...
}
```
