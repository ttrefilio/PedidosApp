using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PedidosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp.Infra.Data.Extensions
{
    /// <summary>
    /// Classe de extensão para configurar a injeção de dependencia
    /// do Entity Framework e dos repositorios da infraestrutura
    /// </summary>
    public static class EntityFrameworkExtension
    {
        public static IServiceCollection AddEntityFrameworkExtension(this IServiceCollection services, IConfiguration configuration)
        {
            //Capturando a string de conexão
            var connectionString = configuration.GetConnectionString("PedidosApp");

            //Fazendo a injeção de dependência da classe DayaContext
            services.AddDbContext<DataContext>(
                //configurando o tipo de banco de dados: SQLServer e passando
                ////o caminho da connectionstring capturadado appsettings
                options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
