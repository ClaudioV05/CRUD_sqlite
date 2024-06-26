﻿using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Crud.Presentation.Api.Extensions.ServiceCollection;

public static class CorsExtensions
{
    /// <summary>
    /// Configure cors.
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureCors(this IServiceCollection services)
    {
        var corsBuilder = new CorsPolicyBuilder();
        corsBuilder.AllowAnyHeader();
        corsBuilder.AllowAnyMethod();
        corsBuilder.AllowAnyOrigin();

        services.AddCors(options => { options.AddDefaultPolicy(corsBuilder.Build()); });
    }
}