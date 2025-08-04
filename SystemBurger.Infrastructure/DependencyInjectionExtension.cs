using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using SystemBurger.Domain.Dtos;
using SystemBurger.Domain.Entities;
using SystemBurger.Domain.Validators;
using SystemBurger.Infrastructure.Data;
using SystemBurger.Infrastructure.Repositories;

namespace SystemBurger.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            AddRepositories(services);
            AddValidators(services);
            AddDbContext(services);
        }

        private static void AddDbContext(IServiceCollection services)
        {
            string connectionString = "Server=localhost;DataBase=SystemBurger;Uid=****;Pwd=****";

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }

        private static void AddValidators(IServiceCollection services)
        {
            services.AddScoped<IValidator<Produto>, ProdutoValidator>();
            //services.AddScoped<IValidator<Cliente>, ClienteValidator>();
            //services.AddScoped<IValidator<Pedido>, PedidoValidator>();
            //services.AddScoped<IValidator<PedidoItem>, PedidoItemValidator>();
        }
    }
}
