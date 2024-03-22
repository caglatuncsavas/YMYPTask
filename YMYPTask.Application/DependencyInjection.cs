﻿using Microsoft.Extensions.DependencyInjection;

namespace YMYPTask.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);
        });

        return services;
    }
}
