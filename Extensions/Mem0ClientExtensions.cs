using Mem0.Net.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Mem0.Net;

public static class Mem0ClientExtensions
{
    public static IServiceCollection AddMem0Client(this IServiceCollection services)
    {
        services.AddOptions<Mem0Options>()
            .BindConfiguration("Mem0");

        services.AddSingleton<IMem0Client, Mem0Client>();

        return services;
    }
}

