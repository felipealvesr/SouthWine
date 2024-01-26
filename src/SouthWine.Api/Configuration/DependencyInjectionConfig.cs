using SouthWine.Business.Intefaces;
using SouthWine.Business.Notificacoes;
using SouthWine.Business.Services;
using SouthWine.Data.Context;
using SouthWine.Data.Repository;
using Microsoft.Extensions.Options;
using SouthWine.Api.Extensions;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SouthWine.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
           // services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();
           // services.AddScoped<IVendaService, VendaService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
