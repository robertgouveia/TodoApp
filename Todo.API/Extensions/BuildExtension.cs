using Todo.Infrastructure.Extensions;

namespace Todo.API.Extensions;

public static class BuildExtension
{
    public static WebApplicationBuilder Configure(this WebApplicationBuilder builder)
    {
        AddInfrastructure(builder);
        builder.Services.AddControllers();

        return builder;
    }

    private static void AddInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddEf(builder.Configuration);
    }
}