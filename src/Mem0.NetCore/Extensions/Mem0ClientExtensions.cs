using Mem0.NetCore.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Mem0.NetCore;

public static class Mem0ClientExtensions
{
    /// <summary>
    /// 注册 Mem0 客户端服务
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddMem0Client(this IServiceCollection services)
    {
        services.AddOptions<Mem0Options>()
            .BindConfiguration("Mem0");

        services.AddSingleton<IMem0Client, Mem0Client>();

        return services;
    }
}

