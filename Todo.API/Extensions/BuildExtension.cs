using Todo.Application.Extensions;
using Todo.Infrastructure.Extensions;

namespace Todo.API.Extensions;

public static class BuildExtension
{
    public static WebApplicationBuilder Configure(this WebApplicationBuilder builder)
    {
        AddInfrastructure(builder);
        AddApplication(builder);
        builder.Services.AddControllers();

        return builder;
    }

    private static void AddInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddEf(builder.Configuration);
        builder.Services.AddInfrastructure();
    }

    private static void AddApplication(this WebApplicationBuilder builder)
    {
        builder.Services.AddMediatR();
    }
}