using AngularClient.Core;
using AngularClient.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

public static class Injector
{
    public static void Register(this IServiceCollection services)
    {
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
    }
}