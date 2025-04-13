using Microsoft.Extensions.DependencyInjection;
using Todo.Domain.Contracts;
using Todo.Infrastructure.Repositories;

namespace Todo.Infrastructure.Extensions;

public static class InfrastructureExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service)
    {
        service.AddTransient<ITodoRepository, TodoRepository>();
        return service;
    }
}