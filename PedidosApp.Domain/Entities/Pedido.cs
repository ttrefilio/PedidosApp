using PedidosApp.Domain.Enums;

namespace PedidosApp.Domain.Entities
{
    /// <summary>
    /// Representação de um pedido no sistema.
    /// </summary>
    public class Pedido
    {
        public required Guid Id { get; set; }
        public required string Solicitante { get; set; }
        public required DateTime DataHora { get; set; }
        public required decimal Valor { get; set; }
        public required string Detalhes { get; set; }
        public required Status Status { get; set; }
        public required bool Ativo { get; set; }
    }
    
}
