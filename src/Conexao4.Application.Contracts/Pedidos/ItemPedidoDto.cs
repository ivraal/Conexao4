using System;
using Volo.Abp.Application.Dtos;

namespace Conexao4.Pedidos;

public class ItemPedidoDto : AuditedEntityDto<Guid>
{
    public Guid UserId { get; set; }

    public int? PedidoId { get; set; }

    public int ProdutoId { get; set; }

    public int Quantidade { get; set; }
}
