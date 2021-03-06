using System.Diagnostics.CodeAnalysis;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Todo.Application;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddAutoMapper(typeof(DependencyInjection).Assembly);
        
        return services;
    }
}