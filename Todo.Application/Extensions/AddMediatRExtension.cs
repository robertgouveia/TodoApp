using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Todo.Application.Extensions;

public static class AddMediatRExtension
{
    public static IServiceCollection AddMediatR(this IServiceCollection service)
    {
        service.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return service;
    }
}