using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Conexao4.Pedidos
{
    public class ItemPedido : AuditedAggregateRoot<int>
    {
        public Guid UserId { get; set; }
        public int? PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}