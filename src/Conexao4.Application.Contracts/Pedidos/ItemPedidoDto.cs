using Conexao4.Produtos;
using System;
using Volo.Abp.Application.Dtos;

namespace Conexao4.Pedidos;

public class ItemPedidoDto : AuditedEntityDto<int>
{
    public Guid UserId { get; set; }

    public int? PedidoId { get; set; }    

    public int ProdutoId { get; set; }

    public ProdutoDto? Produto { get; set; }

    public int Quantidade { get; set; }


}
