using Conexao4.Produtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Conexao4.Pedidos
{
    public class PedidoDto : AuditedEntityDto<int>
    {
        public Guid UserId { get; set; }
    }
}
