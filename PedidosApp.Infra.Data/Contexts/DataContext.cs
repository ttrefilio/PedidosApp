using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PedidosApp.Infra.Data.Configurations;

namespace PedidosApp.Infra.Data.Contexts
{
    /// <summary>
    /// Classe para realizar a configuração do Entity Framework
    /// para acesso a um banco de dados.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Construtor que recebe as configurações de acesso ao banco de dados
        /// </summary>
        /// <param name="options">Contém os parametros de configuração</param>
        public DataContext(DbContextOptions options) :base(options)
        {
            
        }

        /// <summary>
        /// Método para adicionar as classes de configuração das entidades
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        }
    }
}
