using Crud.Infraestructure.Data.Context;
using Crud.Presentation.Api.Extensions;
using Crud.Presentation.Api.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "CRUD_SQLite", Version = "v1" }));

builder.Services.AddControllers(options => options.RespectBrowserAcceptHeader = true);

builder.Services.AddCors();

builder.Services.AddMvc().AddMvcOptions(options => options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter()));

builder.Services.AddDbContext<DatabaseContext>();

builder.Services.TryAddScoped<FilterActionContextController>();
builder.Services.TryAddScoped<FilterActionContextLog>();

builder.Services.AddClassesMatchingInterfaces(nameof(Crud));

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    // Code for Development here.
    app.UseDeveloperExceptionPage();

    app.UseSwagger();
    app.UseSwaggerUI(options => options.EnableTryItOutByDefault());

    app.Use(async (context, next) =>
    {
        if (context.Request.Path == "/Crud")
        {
            context.Response.Redirect("/swagger/index.html");
            return;
        }

        await next();
    });
}
else if (app.Environment.IsStaging())
{
    // Code for Homologation here.
}
else if (app.Environment.IsProduction())
{
    // Code for Production here.

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();