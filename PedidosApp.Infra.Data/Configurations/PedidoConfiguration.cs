using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PedidosApp.Domain.Entities;

namespace PedidosApp.Infra.Data.Configurations
{
    /// <summary>
    /// Classe para configuração da entidade Pedido no banco de dados.
    /// </summary>
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //Nome da tabela no banco de dados
            builder.ToTable("TB_PEDIDO");

            //Chave primária da tabela
            builder.HasKey(p => p.Id);

            //Mapeamento dos campos da tabela
            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Solicitante)
                .HasColumnName("SOLICITANTE")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(P => P.DataHora)
                .HasColumnName("DATAHORA")
                .IsRequired();

            builder.Property(P => P.Detalhes)
                .HasColumnName("DETALHES")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(P => P.Valor)
                .HasColumnName("VALOR") //nome do campo
                .HasColumnType("decimal(10,2)") //tipo do campo
                .IsRequired(); //not null

            builder.Property(p => p.Status)
                .HasColumnName("STATUS")
                .IsRequired();

            builder.Property(P => P.Ativo)
                .HasColumnName("ATIVO")
                .IsRequired();
        }
    }
}
